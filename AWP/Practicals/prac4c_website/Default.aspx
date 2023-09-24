<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Src="~/UserControls/WebUserControl.ascx" TagName="UserControl" TagPrefix="adi" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

    <adi:UserControl  OnFormSubmitted="uc1_FormSubmitted" runat="server" ID="uc1" />
    <adi:WebConfigUC OnFormSubmitted="uc1_FormSubmitted" runat="server" ID="uc2" />

    <asp:TextBox ID="tbInfo" runat="server"></asp:TextBox>
    
    </div>
    </form>
</body>
</html>
