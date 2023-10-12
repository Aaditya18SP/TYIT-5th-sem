<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>
<% @Register TagName="CustomControl" TagPrefix="adi" Src="~/WebUserControl.ascx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <adi:CustomControl ID="adiCC" runat="server" OnSubmitEvent="submitEventHandler" />
    <asp:Label runat="server" ID="lbldisplay" />
    
    </div>
    </form>
</body>
</html>
