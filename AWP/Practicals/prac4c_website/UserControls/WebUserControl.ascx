<%@ Control Language="C#" AutoEventWireup="true" CodeFile="WebUserControl.ascx.cs" Inherits="WebUserControl" %>
<asp:Label ID="lbforName" Text="Your Name:" runat="server" />
<br />
<asp:TextBox ID="tbName" runat="server" />

<br />
<br />

<asp:Label ID="lbforAge" Text="Your age:" runat="server" />
<br />
<asp:TextBox ID="tbAge" runat="server" />

<br />
<br />
<asp:Button ID="btndisplay" Text="display" runat="server" 
    onclick="btndisplay_Click" />

<br />
<asp:Label ID="lblTime" runat="server"></asp:Label>
<br />
<br />

