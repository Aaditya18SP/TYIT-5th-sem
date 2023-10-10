<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1> XML USING XmlTextReader and XmlTextWriter</h1>

    <asp:Label runat="server" ID="lbXmlDisp1" />
    <asp:Button runat="server" ID="btnWriteToXml" Text="Write TO XML" 
            onclick="btnWriteToXml_Click" />
    <asp:Button runat="server" ID="btnFetchXml" Text="Fetch XML" 
            onclick="btnFetchXml_Click" />

    <h1> XML USING XDocument</h1>

    <asp:Label runat="server" ID="lbXmlDisp2" />
    <asp:Button runat="server" ID="Button1" Text="Write TO XML" 
            onclick="Button1_Click" />
    <asp:Button runat="server" ID="Button2" Text="Fetch XML" onclick="Button2_Click" />
    
    </div>
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
    </form>
</body>
</html>
