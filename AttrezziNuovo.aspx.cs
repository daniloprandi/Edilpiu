using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class AttrezziNuovo : System.Web.UI.Page
{
  SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString());
  protected void Page_Load(object sender, EventArgs e)
  {
    if (!IsPostBack)
    {
      conn.Open();
      if (Request.QueryString["id_Attrezzi"] != null)
      {
        int idAttrezzi;
        lblInsModAttrezzo.Text = "MODIFICA ATTREZZO";
        btnSalvaAggiorna.Text = "AGGIORNA";
        if (Int32.TryParse(Request.QueryString["id_Attrezzi"].ToString(), out idAttrezzi))
        {
          using (SqlCommand cmd = new SqlCommand("select * from Attrezzi where id_Attrezzi = @idAttrezzi", conn))
          {
            cmd.Parameters.Add("@idAttrezzi", System.Data.SqlDbType.Int).Value = idAttrezzi;
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
              if (dr.HasRows)
              {
                dr.Read();
                txtDescrizione.Text = dr["descrizione_Attrezzi"].ToString();
                txtQta.Text = dr["quantita_Attrezzi"].ToString();
                txtNote.Text = dr["note_Attrezzi"].ToString();
              }
            }
          }
        }
      }
      conn.Close();
    }
  }

  protected void btnSalvaAggiorna_Click(object sender, EventArgs e)
  {
    lblErrori.Text = "";
    if (txtDescrizione.Text.Trim() == "")
    {
      if (lblErrori.Text == "")
        lblErrori.Text = "<br>Il campo <b>DESCRIZIONE</b> è obbligatorio<br>";
      else
        lblErrori.Text += lblErrori.Text + "<br>Il campo <b>DESCRIZIONE</b> è obbligatorio<br>";
    }
    if (txtQta.Text.Trim() == "")
    {
      if (lblErrori.Text == "")
        lblErrori.Text = "<br>Il campo <b>QUANTITA'</b> è obbligatorio<br>";
      else
        lblErrori.Text += lblErrori.Text + "<br>Il campo <b>QUANTITA'</b> è obbligatorio<br>";
    }
    if (lblErrori.Text != "")
      return;
    conn.Open();
    if (Request.QueryString["id_Attrezzi"] == null)
    {
      using (SqlCommand cmd = new SqlCommand("IF((SELECT COUNT(*) FROM Attrezzi WHERE descrizione_Attrezzi = @descr) > 0) " +
        "BEGIN SET @res = 'K1' RETURN END DECLARE @id AS INT SELECT @id = ISNULL(MAX(id_Attrezzi), 0) + 1 FROM Attrezzi " +
        "INSERT INTO Attrezzi (id_Attrezzi, descrizione_Attrezzi, note_Attrezzi, quantita_Attrezzi) values(@id, @descr, @note, " +
        "@qta) SET @res = 'OK'", conn))
      {
        cmd.Parameters.Add("@descr", SqlDbType.NVarChar, 255).Value = txtDescrizione.Text;
        cmd.Parameters.Add("@note", SqlDbType.Text).Value = txtNote.Text;
        cmd.Parameters.Add("@qta", SqlDbType.Int).Value = txtQta.Text;
        cmd.Parameters.Add("@res", SqlDbType.Char, 2).Direction = ParameterDirection.Output;
        cmd.ExecuteNonQuery();
        string res = cmd.Parameters["@res"].Value.ToString();
        if (res == "OK")
          Response.Redirect("AttrezziElenco.aspx");
        else
          Response.Write("<b>Attrezzo con descrizione: " + txtDescrizione.Text + "</b> già presente nel database. Attrezzo " +
            "non inserito.<br><br>");
      }
    }
    else
    {
      using (SqlCommand cmd = new SqlCommand("update Attrezzi set descrizione_Attrezzi = @descr, note_Attrezzi = @note, " +
        " quantita_Attrezzi = @qta where id_Attrezzi = @id", conn))
      {
        cmd.Parameters.Add("@descr", SqlDbType.NVarChar, 255).Value = txtDescrizione.Text;
        cmd.Parameters.Add("@note", SqlDbType.Text).Value = txtNote.Text;
        cmd.Parameters.Add("@qta", SqlDbType.Int).Value = txtQta.Text;
        cmd.Parameters.Add("@id", SqlDbType.Int).Value = Request.QueryString["id_Attrezzi"].ToString();
        cmd.ExecuteNonQuery();
        Response.Redirect("AttrezziElenco.aspx");
      }
    }
    conn.Close();
  }

  protected void btnAnnulla_Click(object sender, EventArgs e)
  {
    txtDescrizione.Text = "";
    txtQta.Text = "";
    txtNote.Text = "";
  }
}