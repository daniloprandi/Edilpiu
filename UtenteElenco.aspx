<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UtenteElenco.aspx.cs" Inherits="UtenteElenco" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title>Elenco Utenti</title>
</head>
<body>
	<form id="form1" runat="server">
		<div style="font-family: Arial">
			<asp:Label ID="lblElencoUtenti" runat="server" Text="<b>ELENCO UTENTI</b>"></asp:Label><br />
			<br />
			<br />
			<asp:Label runat="server" ID="lblUtentiTotTrov" Text="totale utenti: "></asp:Label>
			<asp:TextBox runat="server" ID="txtUtentiTotTrov" Enabled="false" Width="40px"></asp:TextBox><br />
			<br />
			<table border="1">
				<tr>
					<td><br />
						<asp:Label runat="server" ID="lblTrovaUtente" Text="TROVA UTENTE: " Font-Underline="True"></asp:Label><br />
						<br />
						<asp:Label runat="server" ID="lblTrovaCognome" Text="Cognome: "></asp:Label>
						<asp:TextBox runat="server" ID="txtTrovaCognome" placeholder="inserici cognome..."></asp:TextBox>
						<asp:Label runat="server" ID="lblTrovaNome" Text="Nome: "></asp:Label>
						<asp:TextBox runat="server" ID="txtTrovaNome" placeholder="inserici nome..."></asp:TextBox>
						<asp:Label runat="server" ID="lblTrovaCodiceFiscale" Text="Codice Fiscale: "></asp:Label>
						<asp:TextBox runat="server" ID="txtTrovaCodiceFiscale" placeholder="inserici codice fiscale..."></asp:TextBox>
						<asp:Button runat="server" ID="btnTrovaUtente" OnClick="btnTrovaUtente_Click" Text="TROVA UTENTE" />
						<br />
						<br />
					</td>
				</tr>
			</table><br /><br />
			<asp:GridView ID="gvElencoUtenti" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
				<AlternatingRowStyle BackColor="White" ForeColor="#284775" />
				<Columns>
					<asp:BoundField DataField="id_Utenti" HeaderText="ID" />
					<asp:BoundField DataField="cognome_Utenti" HeaderText="COGNOME" />
					<asp:BoundField DataField="nome_Utenti" HeaderText="NOME" />
					<asp:BoundField DataField="data_nascita_Utenti" HeaderText="DATA DI NASCITA" />
					<asp:BoundField DataField="nome_Nazioni" HeaderText="NAZIONALITA'" />
					<asp:BoundField DataField="codice_fiscale_Utenti" HeaderText="CF" />
					<asp:TemplateField>
						<ItemTemplate>
							<asp:Button
								ID="btnModifica"
								runat="server"
								Text="MODIFICA"
								OnClick="btnModifica_Click"
								CommandArgument='<%#Eval("id_Utenti") %>' />
						</ItemTemplate>
					</asp:TemplateField>
				</Columns>
				<EditRowStyle BackColor="#999999" />
				<FooterStyle BackColor="#5D7B9D" ForeColor="White" Font-Bold="True" />
				<HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
				<PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
				<RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
				<SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
				<SortedAscendingCellStyle BackColor="#E9E7E2" />
				<SortedAscendingHeaderStyle BackColor="#506C8C" />
				<SortedDescendingCellStyle BackColor="#FFFDF8" />
				<SortedDescendingHeaderStyle BackColor="#6F8DAE" />
			</asp:GridView>
		</div>
	</form>
</body>
</html>
