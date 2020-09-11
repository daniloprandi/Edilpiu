using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

public partial class UtenteNuovo : System.Web.UI.Page
{
  SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString());
  protected void Page_Load(object sender, EventArgs e)
  {
    if (!IsPostBack)
    {
      conn.Open();
      SqlCommand cmd = new SqlCommand("select * from sessi", conn);
      SqlDataReader dr = cmd.ExecuteReader();
      ListItem li = new ListItem("- SELEZIONA -", "");
      ddlSesso.Items.Add(li);
      while (dr.Read())
      {
        li = new ListItem(dr["descrizione_Sessi"].ToString(), dr["id_Sessi"].ToString());
        ddlSesso.Items.Add(li);
      }
      dr.Close();
      cmd.Dispose();
      cmd = new SqlCommand("select * from Nazioni", conn);
      dr = cmd.ExecuteReader();
      li = new ListItem("- SELEZIONA -", "");
      ddlNazionalita.Items.Add(li);
      while (dr.Read())
      {
        li = new ListItem(dr["nome_Nazioni"].ToString(), dr["id_Nazioni"].ToString());
        ddlNazionalita.Items.Add(li);
      }
      dr.Close();
      cmd.Dispose();
      cmd = new SqlCommand("select * from [Indirizzi.Tipologia]", conn);
      dr = cmd.ExecuteReader();
      li = new ListItem("- SELEZIONA -", "");
      ddlIndirizzoTip.Items.Add(li);
      while (dr.Read())
      {
        li = new ListItem(dr["descrizione_IndirizziTipologia"].ToString(), dr["id_IndirizziTipologia"].ToString());
        ddlIndirizzoTip.Items.Add(li);
      }
      dr.Close();
      cmd.Dispose();
      cmd = new SqlCommand("select * from [Indirizzi.Tipologia]", conn);
      dr = cmd.ExecuteReader();
      li = new ListItem("- SELEZIONA -", "");
      ddlIndirizzoTip2.Items.Add(li);
      while (dr.Read())
      {
        li = new ListItem(dr["descrizione_IndirizziTipologia"].ToString(), dr["id_IndirizziTipologia"].ToString());
        ddlIndirizzoTip2.Items.Add(li);
      }
      dr.Close();
      cmd.Dispose();
      cmd = new SqlCommand("select * from Province", conn);
      dr = cmd.ExecuteReader();
      li = new ListItem("- SELEZIONA -", "");
      ddlProvincia.Items.Add(li);
      while (dr.Read())
      {
        li = new ListItem(dr["nome_Province"].ToString(), dr["id_Province"].ToString());
        ddlProvincia.Items.Add(li);
      }
      dr.Close();
      cmd.Dispose();
      cmd = new SqlCommand("select * from Province", conn);
      dr = cmd.ExecuteReader();
      li = new ListItem("- SELEZIONA -", "");
      ddlProvincia2.Items.Add(li);
      while (dr.Read())
      {
        li = new ListItem(dr["nome_Province"].ToString(), dr["id_Province"].ToString());
        ddlProvincia2.Items.Add(li);
      }
      dr.Close();
      cmd.Dispose();
      cmd = new SqlCommand("select * from Nazioni", conn);
      dr = cmd.ExecuteReader();
      li = new ListItem("- SELEZIONA -", "");
      ddlNazione.Items.Add(li);
      while (dr.Read())
      {
        li = new ListItem(dr["nome_Nazioni"].ToString(), dr["id_Nazioni"].ToString());
        ddlNazione.Items.Add(li);
      }
      dr.Close();
      cmd.Dispose();
      cmd = new SqlCommand("select * from Nazioni", conn);
      dr = cmd.ExecuteReader();
      li = new ListItem("- SELEZIONA -", "");
      ddlNazione2.Items.Add(li);
      while (dr.Read())
      {
        li = new ListItem(dr["nome_Nazioni"].ToString(), dr["id_Nazioni"].ToString());
        ddlNazione2.Items.Add(li);
      }
      dr.Close();
      cmd.Dispose();
      //cmd = new SqlCommand("select descrizione_Ruoli, id_Ruoli from Ruoli", conn);
      //dr = cmd.ExecuteReader();
      //li = new ListItem("- SELEZIONA -", "");
      //lbxRuoli.Items.Add(li);
      //while (dr.Read())
      //{
      //  li = new ListItem(dr["descrizione_Ruoli"].ToString(), dr["id_Ruoli"].ToString());
      //  lbxRuoli.Items.Add(li);
      //}
      //dr.Close();
      //cmd.Dispose();
      cmd = new SqlCommand("select descrizione_Ruoli, id_Ruoli from Ruoli", conn);
      dr = cmd.ExecuteReader();
      li = new ListItem("- SELEZIONA -", "");
      ddlRuolo1.Items.Add(li);
      while (dr.Read())
      {
        li = new ListItem(dr["descrizione_Ruoli"].ToString(), dr["id_Ruoli"].ToString());
        ddlRuolo1.Items.Add(li);
      }
      dr.Close();
      cmd.Dispose();
      cmd = new SqlCommand("select descrizione_Ruoli, id_Ruoli from Ruoli", conn);
      dr = cmd.ExecuteReader();
      li = new ListItem("- SELEZIONA -", "");
      ddlRuolo2.Items.Add(li);
      while (dr.Read())
      {
        li = new ListItem(dr["descrizione_Ruoli"].ToString(), dr["id_Ruoli"].ToString());
        ddlRuolo2.Items.Add(li);
      }
      dr.Close();
      cmd.Dispose();
      cmd = new SqlCommand("select descrizione_Ruoli, id_Ruoli from Ruoli", conn);
      dr = cmd.ExecuteReader();
      li = new ListItem("- SELEZIONA -", "");
      ddlRuolo3.Items.Add(li);
      while (dr.Read())
      {
        li = new ListItem(dr["descrizione_Ruoli"].ToString(), dr["id_Ruoli"].ToString());
        ddlRuolo3.Items.Add(li);
      }
      dr.Close();
      cmd.Dispose();

      if (Request.QueryString["id_Utenti"] != null)
      {
        lblInsModUtente.Text = "MODIFICA UTENTE";
        btnSalvaAggiorna.Text = "AGGIORNA DATI";
        int id = -1;
        if (Int32.TryParse(Request.QueryString["id_Utenti"].ToString(), out id))
        {
          cmd = new SqlCommand("select * from Utenti where id_Utenti = @id", conn);
          cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
          dr = cmd.ExecuteReader();
          if (dr.HasRows)
          {
            dr.Read();
            txtCognome.Text = dr["cognome_Utenti"].ToString();
            txtNome.Text = dr["nome_Utenti"].ToString();
            txtDataNascita.Text = dr["data_nascita_Utenti"].ToString();
            ddlSesso.Items[ddlSesso.SelectedIndex].Selected = false;
            ddlSesso.Items.FindByValue(dr["id_Sessi"].ToString()).Selected = true;
            ddlNazionalita.Items[ddlNazionalita.SelectedIndex].Selected = false;
            ddlNazionalita.Items.FindByValue(dr["id_Nazioni"].ToString()).Selected = true;
            txtCodiceFiscale.Text = dr["codice_fiscale_Utenti"].ToString();
            txtCodiceFiscale.Enabled = false;
            txtTelefono.Text = dr["telefono_Utenti"].ToString();
            txtEmail.Text = dr["email_Utenti"].ToString();
            txtUserName.Text = dr["username_Utenti"].ToString();
            txtPassword.Text = dr["password_Utenti"].ToString();
            txtNote.Text = dr["note_Utenti"].ToString();
          }
          dr.Close();
          cmd.Dispose();
          cmd = new SqlCommand("select * from Indirizzi where id_Utenti = @id", conn);
          cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
          dr = cmd.ExecuteReader();
          if (dr.HasRows)
          {
            dr.Read();
            ddlIndirizzoTip.Items[ddlIndirizzoTip.SelectedIndex].Selected = false;
            ddlIndirizzoTip.Items.FindByValue(dr["id_IndirizziTipologia"].ToString()).Selected = true;
            txtVia.Text = dr["via_Indirizzi"].ToString();
            txtCap.Text = dr["cap_Indirizzi"].ToString();
            txtCitta.Text = dr["citta_Indirizzi"].ToString();
            ddlProvincia.Items[ddlProvincia.SelectedIndex].Selected = false;
            ddlProvincia.Items.FindByValue(dr["id_Province"].ToString()).Selected = true;
            ddlNazione.Items[ddlNazione.SelectedIndex].Selected = false;
            ddlNazione.Items.FindByValue(dr["id_Nazioni"].ToString()).Selected = true;
            if (dr.Read())
            {
              tblIndirizzo2.Visible = true;
              ddlIndirizzoTip2.Items[ddlIndirizzoTip2.SelectedIndex].Selected = false;
              ddlIndirizzoTip2.Items.FindByValue(dr["id_IndirizziTipologia"].ToString()).Selected = true;
              txtVia2.Text = dr["via_Indirizzi"].ToString();
              txtCap2.Text = dr["cap_Indirizzi"].ToString();
              txtCitta2.Text = dr["citta_Indirizzi"].ToString();
              ddlProvincia2.Items[ddlProvincia.SelectedIndex].Selected = false;
              ddlProvincia2.Items.FindByValue(dr["id_Province"].ToString()).Selected = true;
              ddlNazione2.Items[ddlNazione.SelectedIndex].Selected = false;
              ddlNazione2.Items.FindByValue(dr["id_Nazioni"].ToString()).Selected = true;
            }
          }
        }
        dr.Close();
        cmd.Dispose();
        cmd = new SqlCommand("select * from [Utenti.Ruoli] where id_Utenti = @id", conn);
        cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
        dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
          dr.Read();
          ddlRuolo1.Items[ddlRuolo1.SelectedIndex].Selected = false;
          ddlRuolo1.Items.FindByValue(dr["id_Ruoli"].ToString()).Selected = true;
          if (dr.Read())
          {
            lblRuolo2.Visible = true;
            ddlRuolo2.Visible = true;
            btnAggiungiRuolo3.Visible = true;
            ddlRuolo2.Items[ddlRuolo2.SelectedIndex].Selected = false;
            ddlRuolo2.Items.FindByValue(dr["id_Ruoli"].ToString()).Selected = true;
          }
          if (dr.Read())
          {
            lblRuolo3.Visible = true;
            ddlRuolo3.Visible = true;
            ddlRuolo3.Items[ddlRuolo3.SelectedIndex].Selected = false;
            ddlRuolo3.Items.FindByValue(dr["id_Ruoli"].ToString()).Selected = true;
          }
        }
        dr.Close();
        cmd.Dispose();
      }
      conn.Close();
    }
  }

  protected void btnSalvaAggiorna_Click(object sender, EventArgs e)
  {
    lblErrori.Text = "";

    if (txtCognome.Text.Trim() == "")
      lblErrori.Text = "Il campo <b>COGNOME</b> è obbligatorio<br>";

    if (txtNome.Text.Trim() == "")
    {
      if (lblErrori.Text == "")
        lblErrori.Text = "Il campo <b>NOME</ b > è obbligatorio<br>";
      else
        lblErrori.Text += lblErrori.Text + "Il campo <b>NOME</b> è obbligatorio<br>";
    }

    if (txtDataNascita.Text.Trim() == "")
    {
      if (lblErrori.Text == "")
        lblErrori.Text = "Il campo <b>DATA DI NASCITA</b> è obbligatorio<br>";
      else
        lblErrori.Text = lblErrori.Text + "Il campo <b>DATA DI NASCITA</b> è obbligatorio<br>";
    }

    if (!(ddlNazionalita.SelectedIndex > 0))
    {
      if (lblErrori.Text == "")
        lblErrori.Text = "Il campo <b>NAZIONALITA'</b> è obbligatorio<br>";
      else
        lblErrori.Text = lblErrori.Text + "Il campo <b>NAZIONALITA'</b> è obbligatorio<br>";
    }

    if (txtCodiceFiscale.Text.Trim() == "")
    {
      if (lblErrori.Text == "")
        lblErrori.Text = "Il campo <b>CODICE FISCALE</b> è obbligatorio<br>";
      else
        lblErrori.Text = lblErrori.Text +
            "Il campo <b>CODICE FISCALE</b> è obbligatorio<br>";
    }
    else
    {
      char[] cf = txtCodiceFiscale.Text.Trim().ToCharArray();

      // VERIFICO LUNGHEZZA CODICE FISCALE
      if (cf.Length != 16)
      {
        if (lblErrori.Text == "")
          lblErrori.Text = "La lunghezza del <b>CODICE FISCALE</b> è sbagliata<br>";
        else
          lblErrori.Text = lblErrori.Text +
              "La lunghezza del <b>CODICE FISCALE</b> è sbagliata<br>";
        return;
      }

      byte[] cfAscii = System.Text.Encoding.ASCII.GetBytes(
          txtCodiceFiscale.Text.Trim().ToUpper());

      // controllo che i primi sei caratteri siamo lettere
      for (int i = 0; i < 6; i++)
      {
        if ((cfAscii[i] >= 65) && (cfAscii[i] <= 90))
          continue;
        else
        {
          if (lblErrori.Text == "")
            lblErrori.Text = "Il formato del <b>CODICE FISCALE</b> è sbagliato<br>";
          else
            lblErrori.Text = lblErrori.Text +
                "Il formato del <b>CODICE FISCALE</b> è sbagliato<br>";
          break;
        }
      }

      if (!((cfAscii[6] >= 48) &&
          (cfAscii[6] <= 57) &&
          (cfAscii[7] >= 48) &&
          (cfAscii[7] <= 57)))
      {
        if (lblErrori.Text == "")
          lblErrori.Text = "Il formato del <b>CODICE FISCALE</b> è sbagliato<br>";
        else
          lblErrori.Text = lblErrori.Text +
              "Il formato del <b>CODICE FISCALE</b> è sbagliato<br>";
      }
      if (!((cfAscii[8] >= 65) &&
          (cfAscii[8] <= 90)))
      {
        if (lblErrori.Text == "")
          lblErrori.Text = "Il formato del <b>CODICE FISCALE</b> è sbagliato<br>";
        else
          lblErrori.Text = lblErrori.Text +
              "Il formato del <b>CODICE FISCALE</b> è sbagliato<br>";
      }
      if (!((cfAscii[9] >= 48) &&
          (cfAscii[9] <= 57) &&
          (cfAscii[10] >= 48) &&
          (cfAscii[10] <= 57)))
      {
        if (lblErrori.Text == "")
          lblErrori.Text = "Il formato del <b>CODICE FISCALE</b> è sbagliato<br>";
        else
          lblErrori.Text = lblErrori.Text +
              "Il formato del <b>CODICE FISCALE</b> è sbagliato<br>";
      }
      if (!((cfAscii[11] >= 65) &&
          (cfAscii[11] <= 90)))
      {
        if (lblErrori.Text == "")
          lblErrori.Text = "Il formato del <b>CODICE FISCALE</b> è sbagliato<br>";
        else
          lblErrori.Text = lblErrori.Text +
              "Il formato del <b>CODICE FISCALE</b> è sbagliato<br>";
      }
      if (!((cfAscii[12] >= 48) &&
          (cfAscii[12] <= 57) &&
          (cfAscii[13] >= 48) &&
          (cfAscii[13] <= 57) &&
          (cfAscii[14] >= 48) &&
          (cfAscii[14] <= 57)))
      {
        if (lblErrori.Text == "")
          lblErrori.Text = "Il formato del <b>CODICE FISCALE</b> è sbagliato<br>";
        else
          lblErrori.Text = lblErrori.Text +
              "Il formato del <b>CODICE FISCALE</b> è sbagliato<br>";
      }
    }

    if (!(ddlIndirizzoTip.SelectedIndex > 0))
    {
      if (lblErrori.Text == "")
        lblErrori.Text = "Il campo <b>TIPOLOGIA INDIRIZZO</b> dell'indirizzo 1 è obbligatorio<br>";
      else
        lblErrori.Text = lblErrori.Text + "Il campo <b>TIPOLOGIA INDIRIZZO</b> dell'indirizzo 1 è obbligatorio<br>";
    }

    if (txtVia.Text.Trim() == "")
    {
      if (lblErrori.Text == "")
        lblErrori.Text = "Il campo <b>VIA</b> dell'indirizzo 1 è obbligatorio<br>";
      else
        lblErrori.Text = lblErrori.Text + "Il campo <b>VIA</b> dell'indirizzo 1 è obbligatorio<br>";
    }

    if (txtCap.Text.Trim() == "")
    {
      if (lblErrori.Text == "")
        lblErrori.Text = "Il campo <b>CAP</b> dell'indirizzo 1 è obbligatorio<br>";
      else
        lblErrori.Text = lblErrori.Text + "Il campo <b>CAP</b> dell'indirizzo 1 è obbligatorio<br>";
    }

    if (txtCitta.Text.Trim() == "")
    {
      if (lblErrori.Text == "")
        lblErrori.Text = "Il campo <b>CITTA'</b> dell'indirizzo 1 è obbligatorio<br>";
      else
        lblErrori.Text = lblErrori.Text + "Il campo <b>CITTA'</b> dell'indirizzo 1 è obbligatorio<br>";
    }

    if (!(ddlProvincia.SelectedIndex > 0))
    {
      if (lblErrori.Text == "")
        lblErrori.Text = "Il campo <b>PROVINCIA</b> dell'indirizzo 1 è obbligatorio<br>";
      else
        lblErrori.Text = lblErrori.Text + "Il campo <b>NAZIONALITA'</b> dell'indirizzo 1 è obbligatorio<br>";
    }

    if (!(ddlNazione.SelectedIndex > 0))
    {
      if (lblErrori.Text == "")
        lblErrori.Text = "Il campo <b>PROVINCIA</b> dell'indirizzo 1 è obbligatorio<br>";
      else
        lblErrori.Text = lblErrori.Text + "Il campo <b>NAZIONALITA'</b> dell'indirizzo 1 è obbligatorio<br>";
    }

    if (tblIndirizzo2.Visible == true)
    {
      if (!(ddlIndirizzoTip2.SelectedIndex > 0))
      {
        if (lblErrori.Text == "")
          lblErrori.Text = "Il campo <b>TIPOLOGIA INDIRIZZO</b> dell'indirizzo 2 è obbligatorio<br>";
        else
          lblErrori.Text = lblErrori.Text + "Il campo <b>TIPOLOGIA INDIRIZZO</b> dell'indirizzo 2 è obbligatorio<br>";
      }

      if (txtVia2.Text.Trim() == "")
      {
        if (lblErrori.Text == "")
          lblErrori.Text = "Il campo <b>VIA</b> dell'indirizzo 2 è obbligatorio<br>";
        else
          lblErrori.Text = lblErrori.Text + "Il campo <b>VIA</b> dell'indirizzo 2 è obbligatorio<br>";
      }

      if (txtCap2.Text.Trim() == "")
      {
        if (lblErrori.Text == "")
          lblErrori.Text = "Il campo <b>CAP</b> dell'indirizzo 2 è obbligatorio<br>";
        else
          lblErrori.Text = lblErrori.Text + "Il campo <b>CAP</b> dell'indirizzo 2 è obbligatorio<br>";
      }

      if (txtCitta2.Text.Trim() == "")
      {
        if (lblErrori.Text == "")
          lblErrori.Text = "Il campo <b>CITTA'</b> dell'indirizzo 2 è obbligatorio<br>";
        else
          lblErrori.Text = lblErrori.Text + "Il campo <b>CITTA'</b> dell'indirizzo 2 è obbligatorio<br>";
      }

      if (!(ddlProvincia2.SelectedIndex > 0))
      {
        if (lblErrori.Text == "")
          lblErrori.Text = "Il campo <b>PROVINCIA</b> dell'indirizzo 2 è obbligatorio<br>";
        else
          lblErrori.Text = lblErrori.Text + "Il campo <b>PROVINCIA</b> dell'indirizzo 2 è obbligatorio<br>";
      }

      if (!(ddlNazione2.SelectedIndex > 0))
      {
        if (lblErrori.Text == "")
          lblErrori.Text = "Il campo <b>PROVINCIA</b> è obbligatorio<br>";
        else
          lblErrori.Text = lblErrori.Text + "Il campo <b>PROVINCIA'</b> è obbligatorio<br>";
      }
    }

    if (!(ddlRuolo1.SelectedIndex > 0))
    {
      if (lblErrori.Text == "")
        lblErrori.Text = "Il campo <b>RUOLO 1</b> è obbligatorio<br>";
      else
        lblErrori.Text = lblErrori.Text + "Il campo <b>RUOLO 1</b> è obbligatorio<br>";
    }

    if (lblErrori.Text != "")
      return;

    conn.Open();
    SqlCommand cmd;
    if (Request.QueryString["id_Utenti"] == null)
    {
      cmd = new SqlCommand("IF((SELECT COUNT(*) FROM Utenti WHERE codice_fiscale_Utenti = @cf) > 0) BEGIN SET @res = 'K1' RETURN END " +
      "DECLARE @id AS INT SELECT @id = ISNULL(MAX(id_Utenti), 10000) + 1 FROM Utenti INSERT INTO Utenti (id_Utenti, cognome_Utenti, nome_Utenti, " +
      "data_nascita_Utenti,id_Sessi, id_Nazioni, telefono_Utenti, email_Utenti, note_Utenti, username_Utenti, password_Utenti, codice_fiscale_Utenti)" +
      "values(@id, @cognome, @nome, @dataNascita, @idSessi, @idNazioni, @tel, @email, @note, @username, @pw, @cf) SET @res = 'OK'", conn);
      cmd.Parameters.Add("@cognome", SqlDbType.NVarChar, 255).Value = txtCognome.Text.ToUpper();
      cmd.Parameters.Add("@nome", SqlDbType.NVarChar, 255).Value = txtNome.Text.ToUpper();
      cmd.Parameters.Add("@dataNascita", SqlDbType.Date).Value = DateTime.Parse(txtDataNascita.Text);
      if (ddlSesso.SelectedIndex > 0)
        cmd.Parameters.Add("@idSessi", SqlDbType.NChar, 1).Value = ddlSesso.SelectedValue;
      cmd.Parameters.Add("@idNazioni", SqlDbType.NChar, 3).Value = ddlNazionalita.SelectedValue;
      cmd.Parameters.Add("@cf", SqlDbType.NChar, 16).Value = txtCodiceFiscale.Text.ToUpper();
      cmd.Parameters.Add("@tel", SqlDbType.NVarChar, 255).Value = txtTelefono.Text;
      cmd.Parameters.Add("@email", SqlDbType.NVarChar, 255).Value = txtEmail.Text;
      cmd.Parameters.Add("@note", SqlDbType.Text).Value = txtNote.Text;
      cmd.Parameters.Add("@username", SqlDbType.NVarChar, 40).Value = txtUserName.Text;
      cmd.Parameters.Add("@pw", SqlDbType.NVarChar, 10).Value = txtPassword.Text;
      cmd.Parameters.Add("@res", SqlDbType.Char, 2).Direction = ParameterDirection.Output;
      cmd.ExecuteNonQuery();
      string res = cmd.Parameters["@res"].Value.ToString(); //
      cmd.Dispose(); //
      cmd = new SqlCommand("select id_Utenti from Utenti where codice_fiscale_Utenti = @cf", conn);
      cmd.Parameters.AddWithValue("@cf", txtCodiceFiscale.Text);
      txtId.Text = cmd.ExecuteScalar().ToString();
      int id = Convert.ToInt32(txtId.Text);
      cmd.Dispose(); // 
      cmd = new SqlCommand("insert into Indirizzi(id_Utenti, via_Indirizzi, cap_Indirizzi, citta_Indirizzi, id_Province, id_Nazioni, id_IndirizziTipologia)" +
        " values(@id, @via, @cap, @citta, @idProv, @idNaz, @idIndTip)", conn);
      cmd.Parameters.AddWithValue("@id", txtId.Text).Value = id;
      cmd.Parameters.Add("@via", SqlDbType.NVarChar, 255).Value = txtVia.Text;
      cmd.Parameters.Add("@cap", SqlDbType.Int).Value = txtCap.Text;
      cmd.Parameters.Add("@citta", SqlDbType.NVarChar, 255).Value = txtCitta.Text;
      cmd.Parameters.Add("@idProv", SqlDbType.NChar, 2).Value = ddlProvincia.SelectedValue;
      cmd.Parameters.Add("@idNaz", SqlDbType.NChar, 3).Value = ddlNazione.SelectedValue;
      cmd.Parameters.Add("@idIndTip", SqlDbType.NChar, 2).Value = ddlIndirizzoTip.SelectedValue;
      cmd.ExecuteNonQuery();
      cmd.Dispose();
      if ((txtCitta2 != null) && (ddlIndirizzoTip2.SelectedIndex > 0))
      {
        cmd = new SqlCommand("insert into Indirizzi(id_Utenti, via_Indirizzi, cap_Indirizzi, citta_Indirizzi, id_Province, " +
          "id_Nazioni, id_IndirizziTipologia)values(@id, @via, @cap, @citta, @idProv, @idNaz, @idIndTip)", conn);
        cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
        cmd.Parameters.Add("@via", SqlDbType.NVarChar, 255).Value = txtVia2.Text;
        cmd.Parameters.Add("@cap", SqlDbType.Int).Value = txtCap2.Text;
        cmd.Parameters.Add("@citta", SqlDbType.NVarChar, 255).Value = txtCitta2.Text;
        cmd.Parameters.Add("@idProv", SqlDbType.NChar, 2).Value = ddlProvincia2.SelectedValue;
        cmd.Parameters.Add("@idNaz", SqlDbType.NChar, 3).Value = ddlNazione2.SelectedValue;
        cmd.Parameters.Add("@idIndTip", SqlDbType.NChar, 2).Value = ddlIndirizzoTip2.SelectedValue;
        cmd.ExecuteNonQuery();
        cmd.Dispose();
      }
      cmd = new SqlCommand("insert into [Utenti.Ruoli] (id_Utenti, id_Ruoli)values(@id, @idR)", conn);
      cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
      cmd.Parameters.Add("@idR", SqlDbType.Int).Value = ddlRuolo1.SelectedValue;
      cmd.ExecuteNonQuery();
      if ((ddlRuolo2.SelectedValue != null) && ((ddlRuolo2.SelectedIndex > 0)))
      {
        cmd = new SqlCommand("insert into [Utenti.Ruoli] (id_Utenti, id_Ruoli)values(@id, @idR)", conn);
        cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
        cmd.Parameters.Add("@idR", SqlDbType.Int).Value = ddlRuolo2.SelectedValue;
        cmd.ExecuteNonQuery();
      }
      if ((ddlRuolo3.SelectedValue != null) && ((ddlRuolo3.SelectedIndex > 0)))
      {
        cmd = new SqlCommand("insert into [Utenti.Ruoli] (id_Utenti, id_Ruoli)values(@id, @idR)", conn);
        cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
        cmd.Parameters.Add("@idR", SqlDbType.Int).Value = ddlRuolo3.SelectedValue;
        cmd.ExecuteNonQuery();
      }
      cmd.Dispose();
      if (res == "OK")
        Response.Redirect("UtenteElenco.aspx");
      else
        Response.Write("<b>CF: " + txtCodiceFiscale.Text + "</b> già presente nel database. Utente " + txtCognome.Text + " " + txtNome.Text +
          " non inserito<br><br>");
    }
    else
    {
      cmd = new SqlCommand("update Utenti set cognome_Utenti = @cognome, nome_Utenti = @nome, data_nascita_Utenti = @dataNascita, " +
        " id_Sessi = @idSessi, id_Nazioni = @idNazioni, telefono_Utenti = @tel, email_Utenti = @email, note_Utenti = @note, username_Utenti = @username, " +
        "password_Utenti = @pw, codice_fiscale_Utenti = @cf where id_Utenti = @id", conn);
      cmd.Parameters.Add("@id", SqlDbType.Int).Value = Request.QueryString["id_Utenti"].ToString();
      cmd.Parameters.Add("@cognome", SqlDbType.NVarChar, 255).Value = txtCognome.Text.ToUpper();
      cmd.Parameters.Add("@nome", SqlDbType.NVarChar, 255).Value = txtNome.Text.ToUpper();
      cmd.Parameters.Add("@dataNascita", SqlDbType.Date).Value = DateTime.Parse(txtDataNascita.Text);
      if (ddlSesso.SelectedIndex > 0)
        cmd.Parameters.Add("@idSessi", SqlDbType.NChar, 1).Value = ddlSesso.SelectedValue;
      cmd.Parameters.Add("@idNazioni", SqlDbType.NChar, 3).Value = ddlNazionalita.SelectedValue;
      cmd.Parameters.Add("@tel", SqlDbType.NVarChar, 255).Value = txtTelefono.Text;
      cmd.Parameters.Add("@email", SqlDbType.NVarChar, 255).Value = txtEmail.Text;
      cmd.Parameters.Add("@note", SqlDbType.Text).Value = txtNote.Text;
      cmd.Parameters.Add("@username", SqlDbType.NVarChar, 40).Value = txtUserName.Text;
      cmd.Parameters.Add("@pw", SqlDbType.NVarChar, 10).Value = txtPassword.Text;
      cmd.Parameters.Add("@cf", SqlDbType.NChar, 16).Value = txtCodiceFiscale.Text.ToUpper();
      cmd.ExecuteNonQuery();
      cmd.Dispose(); //
      cmd = new SqlCommand("select id_Utenti from Utenti where codice_fiscale_Utenti = @cf", conn);
      cmd.Parameters.AddWithValue("@cf", txtCodiceFiscale.Text);
      txtId.Text = cmd.ExecuteScalar().ToString();
      int id = Convert.ToInt32(txtId.Text);
      cmd.Dispose(); // 
      cmd = new SqlCommand("update Indirizzi set id_IndirizziTipologia = @idIndTip, via_Indirizzi = @via, cap_Indirizzi = @cap, " +
        " citta_Indirizzi = @citta, id_Province = @idProv, id_Nazioni = @idNaz where id_Utenti = @id", conn);
      cmd.Parameters.Add("@id", SqlDbType.Int).Value = Request.QueryString["id_Utenti"].ToString();
      cmd.Parameters.Add("@via", SqlDbType.NVarChar, 255).Value = txtVia.Text;
      cmd.Parameters.Add("@cap", SqlDbType.Int).Value = txtCap.Text;
      cmd.Parameters.Add("@citta", SqlDbType.NVarChar, 255).Value = txtCitta.Text;
      cmd.Parameters.Add("@idProv", SqlDbType.NChar, 2).Value = ddlProvincia.SelectedValue;
      cmd.Parameters.Add("@idNaz", SqlDbType.NChar, 3).Value = ddlNazione.SelectedValue;
      cmd.Parameters.Add("@idIndTip", SqlDbType.NChar, 2).Value = ddlIndirizzoTip.SelectedValue;
      cmd.ExecuteNonQuery();
      cmd.Dispose(); //
      if ((txtCitta2 != null) && (ddlIndirizzoTip2.SelectedIndex > 0))
      {
        cmd = new SqlCommand("update Indirizzi set id_IndirizziTipologia = @idIndTip2, via_Indirizzi = @via2, cap_Indirizzi = @cap2, " +
        " citta_Indirizzi = @citta2, id_Province = @idProv2, id_Nazioni = @idNaz2 where id_Utenti = @id", conn);
        cmd.Parameters.Add("@id", SqlDbType.Int).Value = Request.QueryString["id_Utenti"].ToString();
        cmd.Parameters.Add("@via2", SqlDbType.NVarChar, 255).Value = txtVia2.Text;
        cmd.Parameters.Add("@cap2", SqlDbType.Int).Value = txtCap2.Text;
        cmd.Parameters.Add("@citta2", SqlDbType.NVarChar, 255).Value = txtCitta2.Text;
        cmd.Parameters.Add("@idProv2", SqlDbType.NChar, 2).Value = ddlProvincia2.SelectedValue;
        cmd.Parameters.Add("@idNaz2", SqlDbType.NChar, 3).Value = ddlNazione2.SelectedValue;
        cmd.Parameters.Add("@idIndTip2", SqlDbType.NChar, 2).Value = ddlIndirizzoTip2.SelectedValue;
        cmd.ExecuteNonQuery();
        cmd.Dispose();
      }
    }
    conn.Close();
  }

  protected void btnAnnulla_Click(object sender, EventArgs e)
  {
    txtCognome.Text = "";
    txtNome.Text = ""; txtDataNascita.Text = "";
    txtDataNascita.Text = "";
    ddlSesso.Items[ddlSesso.SelectedIndex].Selected = false;
    ddlNazionalita.Items[ddlNazionalita.SelectedIndex].Selected = false;
    txtCodiceFiscale.Text = "";
    txtTelefono.Text = "";
    txtEmail.Text = "";
    txtUserName.Text = "";
    txtPassword.Text = "";
    txtNote.Text = "";
    ddlIndirizzoTip.Items[ddlIndirizzoTip.SelectedIndex].Selected = false;
    txtVia.Text = "";
    txtCap.Text = "";
    txtCitta.Text = "";
    ddlProvincia.Items[ddlProvincia.SelectedIndex].Selected = false;
    ddlNazione.Items[ddlNazione.SelectedIndex].Selected = false;
    //for (int i = 0; i < lbxRuoli.Items.Count; i++)
    //  lbxRuoli.Items[i].Selected = false;
    if (tblIndirizzo2.Visible == true)
      tblIndirizzo2.Visible = false;
    ddlRuolo1.Items[ddlRuolo1.SelectedIndex].Selected = false;
    if ((ddlRuolo2.Visible == true))
      ddlRuolo2.Visible = false;
    if (ddlRuolo3.Visible == true)
      ddlRuolo3.Visible = false;
  }

  protected void btnMenuIniziale_Click(object sender, EventArgs e)
  {
    Response.Redirect("Menu_Iniziale.aspx");
  }

  protected void btnElencoUtenti_Click(object sender, EventArgs e)
  {
    Response.Redirect("UtenteElenco.aspx");
  }

  protected void btnAggiungiIndirizzo_Click(object sender, EventArgs e)
  {
    tblIndirizzo2.Visible = true;
  }

  protected void btnAnnullaInsIndirizzo_Click(object sender, EventArgs e)
  {
    ddlIndirizzoTip2.Items[ddlIndirizzoTip2.SelectedIndex].Selected = false;
    txtVia2.Text = "";
    txtCap2.Text = "";
    txtCitta2.Text = "";
    ddlProvincia2.Items[ddlProvincia2.SelectedIndex].Selected = false;
    ddlNazione2.Items[ddlNazione2.SelectedIndex].Selected = false;
    tblIndirizzo2.Visible = false;
  }

  protected void btnAggiungiRuolo2_Click(object sender, EventArgs e)
  {
    lblRuolo2.Visible = true;
    ddlRuolo2.Visible = true;
    btnAggiungiRuolo3.Visible = true;
  }

  protected void brnAggiungiRuolo3_Click(object sender, EventArgs e)
  {
    lblRuolo3.Visible = true;
    ddlRuolo3.Visible = true;
  }
}