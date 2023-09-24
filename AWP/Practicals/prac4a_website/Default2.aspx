<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
   <asp:TextBox runat="server" ID="tbname"></asp:TextBox>

   <asp:CustomValidator runat="server" ErrorMessage="Invalid" 
        onservervalidate="Unnamed1_ServerValidate" ControlToValidate="tbname" 
        ViewStateMode="Enabled" /> 

        <asp:Button runat="server" Text="submit" UseSubmitBehavior="true" />
    </form>
</body>
</html>
