<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AttrezziElenco.aspx.cs" Inherits="AttrezziElenco" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>
</head>
<body>
	<form id="form1" runat="server">
		<div style="font-family: Arial">
			<asp:Label ID="lblElencoAttrezzi" runat="server" Text="<b>ELENCO ATTREZZI</b>"></asp:Label><br />
			<br />
			<br />
			<asp:Label runat="server" ID="lblAttrezziTotTrov" Text="totale attrezzi: "></asp:Label>
			<asp:TextBox runat="server" ID="txtAttrezziTotTrov" Enabled="false" Width="40px"></asp:TextBox><br />
			<br />
			<table border="1">
				<tr>
					<td>
						<asp:Label runat="server" ID="lblTrovaAttrezzo" Text="TROVA ATTREZZO: " Font-Underline="True"></asp:Label><br />
						<br />
						<asp:Label runat="server" ID="lblTrovaDescrizione" Text="Descrizione: "></asp:Label>
						<asp:TextBox runat="server" ID="txtTrovaDescrizione" placeholder="inserici descrizione..."></asp:TextBox>
						<asp:Button runat="server" ID="btnTrovaAttrezzo" Text="TROVA ATTREZZO" BackColor="#00FFCC" OnClick="btnTrovaAttrezzo_Click" />
						<br />
						<br />
					</td>
				</tr>
			</table><br /><br />
			<asp:GridView ID="gvElencoAttrezzi" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
				<AlternatingRowStyle BackColor="White" ForeColor="#284775" />
				<Columns>
					<asp:BoundField DataField="id_Attrezzi" HeaderText="ID" />
					<asp:BoundField DataField="descrizione_Attrezzi" HeaderText="DESCRIZIONE" />
					<asp:BoundField DataField="note_Attrezzi" HeaderText="NOTE" />
					<asp:BoundField DataField="quantita_Attrezzi" HeaderText="QUANTITA'" />
					<asp:TemplateField>
						<ItemTemplate>
							<asp:Button
								ID="btnModifica"
								runat="server"
								Text="MODIFICA"
								OnClick="btnModifica_Click"
								CommandArgument='<%#Eval("id_Attrezzi") %>' />
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
