<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <h1> USING SQLDATASOURCE</h1>
    <asp:GridView runat="server" ID="gvCars" AutoGenerateColumns="False" 
            DataSourceID="SqlDataSource1" >
        <Columns>
            <asp:BoundField DataField="brand" HeaderText="brand" SortExpression="brand" />
            <asp:BoundField DataField="model" HeaderText="model" SortExpression="model" />
            <asp:BoundField DataField="type" HeaderText="type" SortExpression="type" />
            <asp:CommandField ShowEditButton="true" HeaderText="EDIT" />
            <asp:CommandField ShowDeleteButton="true" HeaderText="DELETE" />
            <asp:CommandField ShowSelectButton="true" HeaderText="SELECT" />
        </Columns>
        </asp:GridView>


        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:masterConnectionString %>" 
            SelectCommand="SELECT * FROM [cars_db]"
            UpdateCommand="Update cars_db set brand=@brand, type=@type where model=@model"
            DeleteCommand="DELETE FROM cars_db where model=@model" 
            ConflictDetection="CompareAllValues" >
            </asp:SqlDataSource>

            <br />
            <h1> USING DATASETS</h1>
            <asp:GridView ID="gvDynamicCars" runat="server" 
            onrowediting="gvDynamicCars_RowEditing"  >
            <Columns>
            <asp:CommandField ShowEditButton="true" />
            <asp:CommandField ShowDeleteButton="true" />
            </Columns>
            </asp:GridView>
    
    </div>
    </form>
</body>
</html>
