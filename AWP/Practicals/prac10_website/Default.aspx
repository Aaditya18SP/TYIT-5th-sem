<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1> Method 1: Using XMLTextReader </h1>
    <asp:Button runat="server" id="btnFetchMethod1" Text ="fetch from XML" 
            onclick="btnFetchMethod1_Click" />
    <asp:Button runat="server" ID="btnWriteMethod1" Text ="write to XML" 
            onclick="btnWriteMethod1_Click" />
    <asp:Label runat="server" ID="lbDetails" Width="100%" />
   <!-- <asp:TextBox runat="server" id="tbDetails" Width="100%" Rows="20" TextMode="multiline"/>-->

    <h1> Method 2: Using XDocument </h1>
    <asp:Button runat="server" id="btnFetchMethod2" Text ="fetch from XML" 
            onclick="btnFetchMethod2_Click" />
    <asp:Button runat="server" ID="btnWriteMethod2" Text ="write to XML" 
            onclick="btnWriteMethod2_Click" />
     <asp:GridView runat="server" ID="gridCars"  AutoGenerateColumns="true"/>
     
    </div>
    </form>
</body>
</html>
