<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Menu_Iniziale.aspx.cs" Inherits="Menu_Iniziale" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Menu Iniziale</title>
		<style type="text/css">
			.auto-style1 {
				width: 61px;
			}
	</style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family:Arial">
          <asp:Label text="EDIL+" runat="server" Font-Bold="True"></asp:Label><br />
					<asp:Label ID="Label1" runat="server" Font-Italic="True" Text="più di un'impresa edile!"></asp:Label><br /><br /><br />
					<asp:Label ID="lblMenuIniziale" runat="server" Text="MENU' INIZIALE" Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Underline="True"></asp:Label><br /><br />
          <br /><br />
          <table border="0">
            <tr>
              <td colspan="5">
                <asp:Label
                  id="lblUtenti"
                  text="UTENTI"
                  runat="server" Font-Bold="True"></asp:Label><br /><br />
                <asp:LinkButton
                  id="lkbNuovoUtente"
                  text="Nuovo Utente"
                  runat="server"
                  OnClick="lkbNuovoUtente_Click"></asp:LinkButton><br />
                <asp:LinkButton
                  id="lkbModificaUtente"
                  text="Modifica Utente"
                  runat="server"
                  OnClick="lkbModificaUtente_Click"
                  CommandArgument='<%#Eval("id_Utenti")%>'></asp:LinkButton><br />
                <asp:LinkButton
                  id="lkbElencoUtenti"
                  text="Elenco Utenti"
                  runat="server"
                  OnClick="lkbElencoUtenti_Click"></asp:LinkButton><br />
                <asp:LinkButton
                  id="lkbCancellaUtente"
                  text="Cancella Utente"
                  runat="server"
                  OnClick="lkbCancellaUtente_Click"
                  CommandArgument='<%#Eval("id_Utenti")%>'></asp:LinkButton>
              </td>  
              <td></td><td></td><td></td><td></td><td></td><td></td>
              <td>
                <asp:Label
                id="lblRuoli"
                text="RUOLI"
                runat="server" Font-Bold="true"></asp:Label><br /><br />
                <asp:LinkButton
                  id="lkbNuovoRuolo"
                  text="Nuovo Ruolo"
                  runat="server"
                  OnClick="lkbNuovoRuolo_Click"></asp:LinkButton><br />
                <asp:LinkButton
                  id="lkbModificaRuolo"
                  text="Modifica Ruolo"
                  runat="server"
                  OnClick="lkbModificaRuolo_Click"
                  CommandArgument='<%#Eval("id_Ruoli")%>'></asp:LinkButton><br />
                <asp:LinkButton
                    id="lkbElencoRuoli"
                    text="Elenco Ruoli"
                    runat="server"
                    OnClick="lkbElencoRuoli_Click"></asp:LinkButton><br />
                <asp:LinkButton
                  id="lkbCancellaRuolo"
                  text="Cancella Ruolo"
                  runat="server"
                  OnClick="lkbCancellaRuolo_Click"
                  CommandArgument='<%#Eval("id_Ruoli")%>'></asp:LinkButton><br />
              </td>
              <td></td><td></td><td></td><td></td><td></td><td></td><td></td><td></td><td></td><td></td><td></td><td></td>
              <td>
                <asp:Label
                id="lblCantieri"
                text="CANTIERI"
                runat="server" Font-Bold="true"></asp:Label><br /><br />
                <asp:LinkButton
                  id="lbkNuovoCantiere"
                  text="Nuovo Cantiere"
                  runat="server"
                  OnClick="lbkNuovoCantiere_Click"></asp:LinkButton><br />
                <asp:LinkButton
                  id="lkbModificaCantiere"
                  text="Modifica Cantiere"
                  runat="server"
                  OnClick="lkbModificaCantiere_Click"
                  CommandArgument='<%#Eval("id_Cantieri")%>'></asp:LinkButton><br />
                <asp:LinkButton
                    id="lkbElencoCantieri"
                    text="Elenco Cantieri"
                    runat="server"
                    OnClick="lkbElencoCantieri_Click"></asp:LinkButton><br />
                <asp:LinkButton
                  id="lkbCancellaCantiere"
                  text="Cancella Cantiere"
                  runat="server"
                  OnClick="lkbCancellaCantiere_Click"
                  CommandArgument='<%#Eval("id_Cantieri")%>'></asp:LinkButton><br />
              </td>
              <td></td><td></td><td></td><td></td><td></td><td></td>
              <td>
                <asp:Label
                id="lblMezzi"
                text="MEZZI"
                runat="server" Font-Bold="true"></asp:Label><br /><br />
                <asp:LinkButton
                  id="lkbNuovoMezzo"
                  text="Nuovo Mezzo"
                  runat="server"
                  OnClick="lkbNuovoMezzo_Click"></asp:LinkButton><br />
                <asp:LinkButton
                  id="lkbModificaMezzo"
                  text="Modifica Mezzo"
                  runat="server"
                  OnClick="lkbModificaMezzo_Click"
                  CommandArgument='<%#Eval("id_Mezzi")%>'></asp:LinkButton><br />
                <asp:LinkButton
                    id="lkbElencoMezzi"
                    text="Elenco Mezzi"
                    runat="server"
                    OnClick="lkbElencoMezzi_Click"></asp:LinkButton><br />
                <asp:LinkButton
                  id="lkbCancellaMezzo"
                  text="Cancella Mezzo"
                  runat="server"
                  OnClick="lkbCancellaMezzo_Click"
                  CommandArgument='<%#Eval("id_Mezzi")%>'></asp:LinkButton><br />
              </td>
              <td></td><td></td><td></td><td></td><td></td><td></td>
              <td>
                <asp:Label
                id="lblAttrezzi"
                text="ATTREZZI"
                runat="server" Font-Bold="true"></asp:Label><br /><br />
                <asp:LinkButton
                  id="lkbNuovoAttrezzo"
                  text="Nuovo Attrezzo"
                  runat="server"
                  OnClick="lkbNuovoAttrezzo_Click"></asp:LinkButton><br />
                <asp:LinkButton
                  id="lkbModificaAttrezzo"
                  text="Modifica Attrezzo"
                  runat="server"
                  OnClick="lkbModificaAttrezzo_Click"
                  CommandArgument='<%#Eval("id_Attrezzi")%>'></asp:LinkButton><br />
                <asp:LinkButton
                    id="lkbElencoAttrezzi"
                    text="Elenco Attrezzi"
                    runat="server"
                    OnClick="lkbElencoAttrezzi_Click"></asp:LinkButton><br />
                <asp:LinkButton
                  id="lkbCancellaAttrezzi"
                  text="Cancella Attrezzi"
                  runat="server"
                  OnClick="lkbCancellaAttrezzi_Click"
                  CommandArgument='<%#Eval("id_Attrezzi")%>'></asp:LinkButton><br />
              </td>
            </tr>
          </table>
        </div>
    </form>
</body>
</html>
