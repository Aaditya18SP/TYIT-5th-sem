<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

    <h1> GRIDVIEW 1- using SqlDataSource</h1>
    
    <div class="grid_view">
        <asp:GridView ID="gvStudents" runat="server"  AutoGenerateColumns="False" 
            DataSourceID="SqlDataSource1" EmptyDataText="Nothing here" ShowFooter="True">
            <Columns>
            
            <asp:ButtonField CommandName="select" DataTextField="control_id" />

             
                <asp:BoundField DataField="control_id" HeaderText="control_id" 
                    SortExpression="control_id" />
                <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
                <asp:BoundField DataField="contactno" HeaderText="contactno" 
                    SortExpression="contactno" />
                <asp:BoundField DataField="address" HeaderText="address" 
                    SortExpression="address" ReadOnly="False" />
                    <asp:CommandField ShowEditButton="true" HeaderText="edit info" />
                    <asp:CommandField HeaderText="Select info" ShowSelectButton="true" />
                   
                    <asp:CommandField  HeaderText="Delete info" ShowDeleteButton="true" />
                   
                    
                   
            </Columns>
        </asp:GridView>

        <!--With data source-->
    
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:masterConnectionString %>" 
            SelectCommand="SELECT * FROM [students]" 
            
            UpdateCommand="UPDATE students SET name = @name WHERE (control_id = @control_id)" 
            DeleteCommand="delete from [students] where [control_id] = @control_id" 
            ConflictDetection="CompareAllValues" >
           
            </asp:SqlDataSource>
    
   
   <h1> GRIDVIEW 2- using Dataset</h1>
         <asp:GridView ID="gvStudentsDataBind" runat="server"  
            EmptyDataText="Nothing here" ShowFooter="True" 
            onrowdeleting="gvStudentsDataBind_RowDeleting" 
            onrowediting="gvStudentsDataBind_RowEditing"
            onselectedindexchanged="gvStudentsDataBind_SelectedIndexChanged">
            <Columns>
             <asp:CommandField ShowEditButton="true" HeaderText="edit info" />
                    <asp:CommandField HeaderText="Select info" ShowSelectButton="true" />
                   
                    <asp:CommandField  HeaderText="Delete info" ShowDeleteButton="true" />
            </Columns>
        </asp:GridView>
    
    


    </div>

    </div>
    </form>
</body>
</html>
