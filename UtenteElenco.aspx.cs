using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UtenteElenco : System.Web.UI.Page
{
  SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString());
  protected void Page_Load(object sender, EventArgs e)
  {
    if (!IsPostBack)
    {
      conn.Open();
      SqlCommand cmd = new SqlCommand("select count(*) from Utenti", conn);
      txtUtentiTotTrov.Text = cmd.ExecuteScalar().ToString();
      conn.Close();
      SqlDataAdapter da = new SqlDataAdapter("select id_Utenti, cognome_Utenti, nome_Utenti, data_nascita_Utenti, " +
      " nome_Nazioni, codice_fiscale_Utenti from Utenti u inner join Nazioni n on u.id_Nazioni = n.id_Nazioni " +
      "order by cognome_Utenti, codice_fiscale_Utenti", conn);
      DataSet ds = new DataSet();
      da.Fill(ds);
      gvElencoUtenti.DataSource = ds;
      gvElencoUtenti.DataBind();
    }
  }


  protected void btnModifica_Click(object sender, EventArgs e)
  {
    string idUtenti = ((Button)sender).CommandArgument.ToString();
    Response.Redirect("UtenteNuovo.aspx?id_Utenti=" + idUtenti);
  }

  protected void btnVisualizza_Click(object sender, EventArgs e)
  {

  }

  protected void btnTrovaUtente_Click(object sender, EventArgs e)
  {
    SqlCommand cmd = new SqlCommand("select id_Utenti, cognome_Utenti, nome_Utenti, data_nascita_Utenti, " +
      " nome_Nazioni, codice_fiscale_Utenti from Utenti u inner join Nazioni n on u.id_Nazioni = n.id_Nazioni where " +
      " cognome_Utenti like @cognome and nome_Utenti like @nome and codice_fiscale_Utenti like @cf", conn);
    cmd.Parameters.AddWithValue("@cognome", txtTrovaCognome.Text + "%");
    cmd.Parameters.AddWithValue("@nome", txtTrovaNome.Text + "%");
    cmd.Parameters.AddWithValue("@cf", txtTrovaCodiceFiscale.Text + "%");
    conn.Open();
    SqlDataReader dr = cmd.ExecuteReader();
    gvElencoUtenti.DataSource = dr;
    gvElencoUtenti.DataBind();
    lblUtentiTotTrov.Text = "utenti trovati: ";
    dr.Close();
    dr.Dispose();
    cmd.Dispose();
    cmd = new SqlCommand("select COUNT(*) from Utenti where cognome_Utenti like @cognome and nome_Utenti like @nome and " +
      " codice_fiscale_Utenti like @cf ", conn);
    cmd.Parameters.AddWithValue("@cognome", txtTrovaCognome.Text + "%");
    cmd.Parameters.AddWithValue("@nome", txtTrovaNome.Text + "%");
    cmd.Parameters.AddWithValue("@cf", txtTrovaCodiceFiscale.Text + "%");
    txtUtentiTotTrov.Text = cmd.ExecuteScalar().ToString();
    cmd.Dispose();
    conn.Close();
  }
}