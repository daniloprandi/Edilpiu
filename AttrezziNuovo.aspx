<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AttrezziNuovo.aspx.cs" Inherits="AttrezziNuovo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>
</head>
<body>
	<form id="form1" runat="server">
		<div style="font-family: Arial">
			<asp:Label ID="lblInsModAttrezzo" runat="server" Text="INSERISCI ATTREZZO" Font-Bold="True"></asp:Label><br />
			<br />
			<br />
			<asp:Label ID="lblErrori" runat="server"></asp:Label>
			<br />
			<br />
			<asp:Label runat="server" ID="lblDescrizione" Text="DESCRIZIONE: "></asp:Label>
			<asp:TextBox runat="server" id="txtDescrizione" Width="592px"></asp:TextBox>
			&nbsp;<asp:Label runat="server" ID="lblQta" Text="QUANTITA': "></asp:Label>
			<asp:TextBox runat="server" ID="txtQta" Height="26px" Width="50px" ></asp:TextBox><br /><br />
			<asp:Label runat="server" ID="lblNote" Text="NOTE: "></asp:Label><br /><br />
			<asp:TextBox runat="server" id="txtNote" Height="127px" Width="318px"></asp:TextBox><br /><br /><br />
			<asp:Button runat="server" ID="btnSalvaAggiorna" Text="SALVA" BackColor="#00FF99" Font-Bold="True" Height="74px" 
				OnClick="btnSalvaAggiorna_Click" Width="151px" />
			<asp:Button runat="server" ID="btnAnnulla" Text="Annulla" BackColor="#FF0066" Height="74px" 
				 Width="151px" OnClick="btnAnnulla_Click" />
		</div>
	</form>
</body>
</html>
