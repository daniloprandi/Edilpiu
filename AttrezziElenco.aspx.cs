using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

public partial class AttrezziElenco : System.Web.UI.Page
{
  SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString());
  protected void Page_Load(object sender, EventArgs e)
  {
    if (!IsPostBack)
    {
      conn.Open();
      SqlCommand cmd = new SqlCommand("select count(*) from Attrezzi", conn);
      txtAttrezziTotTrov.Text = cmd.ExecuteScalar().ToString();
      cmd.Dispose();
      conn.Close();
      SqlDataAdapter da = new SqlDataAdapter("select id_Attrezzi, descrizione_Attrezzi, note_Attrezzi, quantita_Attrezzi " +
        "from Attrezzi", conn);
      DataSet ds = new DataSet();
      da.Fill(ds);
      gvElencoAttrezzi.DataSource = ds;
      gvElencoAttrezzi.DataBind();
      da.Dispose();
      conn.Close();
    }
  }

  protected void btnTrovaAttrezzo_Click(object sender, EventArgs e)
  {
    conn.Open();
    using (SqlCommand cmd = new SqlCommand("select id_Attrezzi, descrizione_Attrezzi, quantita_Attrezzi, note_Attrezzi " +
      " from Attrezzi where descrizione_Attrezzi like @descr", conn))
    {
      cmd.Parameters.AddWithValue("@descr", txtTrovaDescrizione.Text + "%");
      using (SqlDataReader dr = cmd.ExecuteReader())
      {
        gvElencoAttrezzi.DataSource = dr;
        gvElencoAttrezzi.DataBind();
        lblAttrezziTotTrov.Text = "attrezzi trovati: ";
      }
      cmd.CommandText = "select COUNT(*) from Attrezzi where descrizione_Attrezzi like @desc";
      cmd.Parameters.Add("@desc", SqlDbType.NVarChar, 255).Value = txtTrovaDescrizione.Text + "%";
      txtAttrezziTotTrov.Text = cmd.ExecuteScalar().ToString();
    }
    conn.Close();
  }

  protected void btnModifica_Click(object sender, EventArgs e)
  {
    string idAttrezzi = ((Button)sender).CommandArgument.ToString();
    Response.Redirect("AttrezziNuovo.aspx?id_Attrezzi=" + idAttrezzi);
  }
}