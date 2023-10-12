<%@ Control Language="C#" AutoEventWireup="true" CodeFile="WebUserControl.ascx.cs" Inherits="WebUserControl" %>

<asp:Label runat="server" ID="lblName" Text="name" />
<asp:TextBox runat="server" ID="tbName" ></asp:TextBox>
<asp:Button runat="server" ID="btnDisplay" Text="display" 
    onclick="btnDisplay_Click" />
<asp:Label runat="server" ID="idDispTime" />
