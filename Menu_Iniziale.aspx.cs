using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Menu_Iniziale : System.Web.UI.Page
{
  protected void Page_Load(object sender, EventArgs e)
  {
 
  }

  protected void lkbNuovoUtente_Click(object sender, EventArgs e)
  {
    Response.Redirect("UtenteNuovo.aspx");
  }

  protected void lkbModificaUtente_Click(object sender, EventArgs e)
  {
  }

  protected void lkbElencoUtenti_Click(object sender, EventArgs e)
  {
    Response.Redirect("UtenteElenco.aspx");
  }

  protected void lkbCancellaUtente_Click(object sender, EventArgs e)
  {

  }

  protected void lkbNuovoRuolo_Click(object sender, EventArgs e)
  {

  }

  protected void lkbModificaRuolo_Click(object sender, EventArgs e)
  {

  }

  protected void lkbElencoRuoli_Click(object sender, EventArgs e)
  {

  }

  protected void lkbCancellaRuolo_Click(object sender, EventArgs e)
  {

  }

  protected void lbkNuovoCantiere_Click(object sender, EventArgs e)
  {

  }

  protected void lkbModificaCantiere_Click(object sender, EventArgs e)
  {

  }

  protected void lkbElencoCantieri_Click(object sender, EventArgs e)
  {

  }

  protected void lkbCancellaCantiere_Click(object sender, EventArgs e)
  {

  }

  protected void lkbNuovoMezzo_Click(object sender, EventArgs e)
  {

  }

  protected void lkbModificaMezzo_Click(object sender, EventArgs e)
  {

  }

  protected void lkbElencoMezzi_Click(object sender, EventArgs e)
  {

  }

  protected void lkbCancellaMezzo_Click(object sender, EventArgs e)
  {

  }

  protected void lkbNuovoAttrezzo_Click(object sender, EventArgs e)
  {
    Response.Redirect("AttrezziNuovo.aspx");
  }

  protected void lkbModificaAttrezzo_Click(object sender, EventArgs e)
  {

  }

  protected void lkbElencoAttrezzi_Click(object sender, EventArgs e)
  {
    Response.Redirect("AttrezziElenco.aspx");
  }

  protected void lkbCancellaAttrezzi_Click(object sender, EventArgs e)
  {

  }
}