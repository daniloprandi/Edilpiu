<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UtenteNuovo.aspx.cs" Inherits="UtenteNuovo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title>Inserisci - Modifica Utente</title>
</head>
<body>
	<form id="form1" runat="server">
		<div style="font-family: Arial">
			<asp:Label ID="lblInsModUtente" runat="server" Text="INSERISCI UTENTE" Font-Bold="True"></asp:Label><br />
			<br />
			<br />
			<asp:Label ID="lblErrori" runat="server"></asp:Label><br /><br />
			<asp:Label ID="lblDatiAnagrafici" runat="server" Text="Dati Anagrafici" Font-Underline="true"></asp:Label><br />
			<br />
			<asp:TextBox runat="server" ID="txtId" Visible="false"></asp:TextBox>
			<table border="0">
				<tr>
					<td colspan="2">
						<asp:Label runat="server" ID="lblCognome" Text="COGNOME: " Font-Bold="true"></asp:Label>
						<asp:TextBox runat="server" ID="txtCognome"></asp:TextBox>
						<asp:Label runat="server" ID="lblNome" Text="NOME: " Font-Bold="true"></asp:Label>
						<asp:TextBox runat="server" ID="txtNome"></asp:TextBox><br />
					</td>
				</tr>
				<tr>
					<td colspan="4">
						<asp:Label runat="server" ID="lblDataNascita" Text="DATA DI NASCITA: " Font-Bold="true"></asp:Label>
						<asp:TextBox ID="txtDataNascita" runat="server"></asp:TextBox>
						<asp:Label runat="server" ID="lblSesso" Text="SESSO: " Font-Bold="true"></asp:Label>
						<asp:DropDownList runat="server" ID="ddlSesso"></asp:DropDownList>
						<asp:Label runat="server" ID="lblNazionalita" Text="NAZIONALITA': " Font-Bold="true"></asp:Label>
						<asp:DropDownList runat="server" ID="ddlNazionalita"></asp:DropDownList>
						<asp:Label runat="server" ID="lblCodiceFiscale" Text="CODICE FISCALE: " Font-Bold="true"></asp:Label>
						<asp:TextBox runat="server" ID="txtCodiceFiscale" Width="352px"></asp:TextBox>
					</td>
				</tr>
				<tr>
					<td colspan="4">
						<asp:Label runat="server" ID="lblTelefono" Text="TELEFONO: " Font-Bold="true"></asp:Label>
						<asp:TextBox runat="server" ID="txtTelefono"></asp:TextBox>
						<asp:Label runat="server" ID="lblEmail" Text="E-MAIL: " Font-Bold="true"></asp:Label>
						<asp:TextBox runat="server" ID="txtEmail"></asp:TextBox>
						<asp:Label runat="server" ID="lblUsername" Text="USERNAME: " Font-Bold="true"></asp:Label>
						<asp:TextBox runat="server" ID="txtUserName"></asp:TextBox>
						<asp:Label runat="server" ID="lblPassword" Text="PASSWORD: " Font-Bold="true"></asp:Label>
						<asp:TextBox runat="server" ID="txtPassword"></asp:TextBox><br />
					</td>
				</tr>
				<tr>
					<td>
						<asp:Label runat="server" ID="lblNote" Text="NOTE: " Font-Bold="true"></asp:Label><br />
						<asp:TextBox runat="server" ID="txtNote" Height="83px" Width="489px"></asp:TextBox>
					</td>
				</tr>
			</table>
			<br />
			<asp:Label ID="lblIndirizzo" runat="server" Text="Indirizzo" Font-Underline="true"></asp:Label><br />
			<br />
			<br />
			<table border="0" id="tblIndirizzo1">
				<tr>
					<td colspan="3">
						<asp:Label runat="server" ID="lblIndirizzoTip" Text="TIPOLOGIA INDIRIZZO: " Font-Bold="true"></asp:Label>
						<asp:DropDownList runat="server" ID="ddlIndirizzoTip"></asp:DropDownList>
						<asp:Label runat="server" ID="lblVia" Text="VIA: " Font-Bold="true"></asp:Label>
						<asp:TextBox runat="server" ID="txtVia"></asp:TextBox>
						<asp:Label runat="server" ID="lblCap" Text="CAP: " Font-Bold="true"></asp:Label>
						<asp:TextBox runat="server" ID="txtCap"></asp:TextBox>
					</td>
				</tr>
				<tr>
					<td colspan="4">
						<asp:Label runat="server" ID="lblCitta" Text="CITTA': " Font-Bold="true"></asp:Label>
						<asp:TextBox runat="server" ID="txtCitta"></asp:TextBox>
						<asp:Label runat="server" ID="lblProvincia" Text="PROVINCIA: " Font-Bold="true"></asp:Label>
						<asp:DropDownList runat="server" ID="ddlProvincia"></asp:DropDownList>
						<asp:Label runat="server" ID="lblNazione" Text="NAZIONE: " Font-Bold="true"></asp:Label>
						<asp:DropDownList runat="server" ID="ddlNazione"></asp:DropDownList>
						<asp:Button runat="server" ID="btnAggiungiIndirizzo" OnClick="btnAggiungiIndirizzo_Click" Text="Aggiungi Indirizzo" /><br />
						
					</td>
				</tr>
			</table><br />
			<%--INDIRIZZO 2 INIZIO--%>
			<table id="tblIndirizzo2" runat="server" Visible="false">
				<tr>
					<td colspan="3">
						<asp:Label runat="server" ID="lblIndirizzoTip2" Text="TIPOLOGIA INDIRIZZO: " Font-Bold="true" Visible =" true"></asp:Label>
						<asp:DropDownList runat="server" ID="ddlIndirizzoTip2" Visible =" true"></asp:DropDownList>
						<asp:Label runat="server" ID="lblVia2" Text="VIA: " Font-Bold="true" Visible =" true"></asp:Label>
						<asp:TextBox runat="server" ID="txtVia2" Visible =" true"></asp:TextBox>
						<asp:Label runat="server" ID="lblCap2" Text="CAP: " Font-Bold="true" Visible =" true"></asp:Label>
						<asp:TextBox runat="server" ID="txtCap2" Visible =" true"></asp:TextBox>
					</td>
				</tr>
				<tr>
					<td colspan="4">
						<asp:Label runat="server" ID="lblCitta2" Text="CITTA': " Font-Bold="true"></asp:Label>
						<asp:TextBox runat="server" ID="txtCitta2"></asp:TextBox>
						<asp:Label runat="server" ID="lblProvincia2" Text="PROVINCIA: " Font-Bold="true"></asp:Label>
						<asp:DropDownList runat="server" ID="ddlProvincia2"></asp:DropDownList>
						<asp:Label runat="server" ID="lblNazione2" Text="NAZIONE: " Font-Bold="true"></asp:Label>
						<asp:DropDownList runat="server" ID="ddlNazione2"></asp:DropDownList>
						<asp:Button runat="server" ID="btnAnnullaInsIndirizzo" Text="Annulla Indirizzo"
								BackColor="#FF3300" OnClick="btnAnnullaInsIndirizzo_Click" />
						<br />
						<br />
					</td>
				</tr>
			</table>
			<%--INDIRIZZO 2 FINE--%>
			<asp:Label runat="server" ID="lblRuoli" Text="Ruolo/i: " Font-Underline="true"></asp:Label><br />
			<br />
			<%--<asp:ListBox runat="server" ID="lbxRuoli" SelectionMode="Multiple"></asp:ListBox><br />--%>
			<table border="0">
				<tr>
					<td colspan="3">
						<asp:Label runat="server" ID="lblRuolo1" Text="Ruolo: "></asp:Label>
						<asp:DropDownList runat="server" ID="ddlRuolo1"></asp:DropDownList>
						<asp:Button runat="server" ID="btnAggiungiRuolo2" Text="AggiungiRuolo 2" OnClick="btnAggiungiRuolo2_Click" />
						<asp:Label runat="server" ID="lblRuolo2" Text="Ruolo 2:" Visible="false"></asp:Label>
						<asp:DropDownList runat="server" ID="ddlRuolo2" Visible="false"></asp:DropDownList>
						<asp:Button runat="server" ID="btnAggiungiRuolo3" Text="Aggiungi Ruolo 3" Visible="false" OnClick="brnAggiungiRuolo3_Click" />
						<asp:Label runat="server" ID="lblRuolo3" Text="Ruolo 3: " Visible="false"></asp:Label>
						<asp:DropDownList runat="server" ID="ddlRuolo3" Visible="false"></asp:DropDownList>
					</td>
				</tr>
			</table>
			<br />
			<br />
			<table border="0">
				<tr>
					<td colspan="2">
						<asp:Button runat="server" ID="btnSalvaAggiorna" BackColor="#00FF99" Font-Bold="True" Height="60px" Text="SALVA" Width="181px" OnClick="btnSalvaAggiorna_Click" />
						<asp:Button ID="btnAnnulla" runat="server" BackColor="#FF3300" Font-Bold="True" Height="60px" OnClick="btnAnnulla_Click" Text="Annulla" Width="203px" />
					</td>
				</tr>
			</table>
			<br />
			<br />
			<table border="0">
				<tr>
					<td colspan="2">
						<asp:Button runat="server" ID="btnMenuIniziale" Font-Bold="True" Height="48px" OnClick="btnMenuIniziale_Click" Text="Torna a menù iniziale" Width="310px" />
						<asp:Button runat="server" ID="btnElencoUtenti" Font-Bold="True" Height="48px" OnClick="btnElencoUtenti_Click" Text="Elenco Utenti" Width="310px" />
					</td>
				</tr>
			</table>
		</div>
	</form>
</body>
</html>
