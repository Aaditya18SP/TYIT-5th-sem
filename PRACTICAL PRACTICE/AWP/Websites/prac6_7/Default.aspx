<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:GridView ID="gvCars" runat="server" />
<asp:ListBox ID="lboxCars" width="100%" runat="server" AutoPostBack="True" 
            onselectedindexchanged="lboxCars_SelectedIndexChanged" />
<br />

<asp:Label runat="server" ID="lblError" />

<br />

<h1> Specific item details</h1>
<asp:Label ID="lblid" runat="server" text="id"/>
<br />
<asp:TextBox ID="tbId" runat="server"  Enabled="false"/>
<br />
<br />

<asp:Label ID="Label1" runat="server" text="brand"/>
<br />
<asp:TextBox ID="TextBox1" runat="server" />
<br />
<br />

<asp:Label ID="Label2" runat="server" text="model"/>
<br />
<asp:TextBox ID="TextBox2" runat="server" />
<br />
<br />

<asp:Label ID="Label3" runat="server" Text="type" />
<br />
<asp:TextBox ID="TextBox3" runat="server" />
<br />
<br />

<asp:Button ID="btnSave" runat="server" Text="Save" onclick="btnSave_Click"/>
<asp:Button ID="btnDelete" runat="server" Text="delete" onclick="btnDelete_Click" />

<h1> INSERTT</h1>
<asp:Label ID="Label4" runat="server" text="id"/>
<br />
<asp:TextBox ID="TextBox4" runat="server" />
<br />
<br />

<asp:Label ID="Label5" runat="server" text="brand"/>
<br />
<asp:TextBox ID="TextBox5" runat="server" />
<br />
<br />

<asp:Label ID="Label6" runat="server" text="model"/>
<br />
<asp:TextBox ID="TextBox6" runat="server" />
<br />
<br />

<asp:Label ID="Label7" runat="server" Text="type" />
<br />
<asp:TextBox ID="TextBox7" runat="server" />
<br />
<br />

<asp:Button ID="btnInsert" runat="server" Text="Insert" onclick="btnInsert_Click"/>
    
    </div>
    </form>
</body>
</html>
