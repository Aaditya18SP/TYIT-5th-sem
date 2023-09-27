<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TreeView runat="server" ID="tvCarBrands" ExpandDepth="0" ShowLines="true" 
            NodeIndent="50" ShowExpandCollapse="true" SelectedNodeStyle-BorderColor="red"
            onselectednodechanged="tvCarBrands_SelectedNodeChanged" >
            <Nodes >
                <asp:TreeNode Text="Volkswagen" NavigateUrl="https://www.volkswagen-group.com/en" ImageUrl="car_icon.png">
                    <asp:TreeNode Text="Audi" expanded="true">
                        <asp:TreeNode Text="Lamborghini"/>
                    </asp:TreeNode>
                    <asp:TreeNode Text="Bugatti" />
                    <asp:TreeNode Text="Porsche">
                        <asp:TreeNode Text="Rimac" />
                    </asp:TreeNode>
                    <asp:TreeNode Text="Skoda" />
                    <asp:TreeNode Text="Bentley" />
                </asp:TreeNode>

                <asp:TreeNode Text="BMW Group">
                    <asp:TreeNode Text="BMW" />
                    <asp:TreeNode Text="Rolls Royce" />
                </asp:TreeNode>
                <asp:TreeNode Text="Tata">
                    <asp:TreeNode Text="Jaguar" />
                    <asp:TreeNode Text="Land Rover" />
                </asp:TreeNode>
                <asp:TreeNode Text="Dailmer">
                    <asp:TreeNode Text="Mercedes-Benz" />
                </asp:TreeNode>

            </Nodes>
    </asp:TreeView>
    

    <br />
    <br />

    <asp:Button runat="server" ID="btnAddNode" Text="Add node" 
            onclick="btnAddNode_Click" />
    <asp:Button runat="server" ID="btnRemoveNode" Text="Remove node" 
            onclick="btnRemoveNode_Click"/>
        <asp:Button ID="btnModifyNode" runat="server" onclick="btnModifyNode_Click" 
            Text="Modify Node" />
        <asp:Button ID="btnExpand" runat="server" 
            Text="Expand Node" onclick="btnExpand_Click" />
            <asp:Button ID="btnCollapse" runat="server" 
            Text="Collapse Node" onclick="btnCollapse_Click" />
    <br />
    <br />
    
        <asp:TextBox ID="tbDisplay"  Width="100%" Rows="10" runat="server" TextMode="Multiline"></asp:TextBox>
    </div>

    <!--DATALIST CONTROL-->
    <asp:DataList ID="dataList" runat="server" DataSourceID="SqlDataSource1" 
         GridLines="Both" 
        onselectedindexchanged="dataList_SelectedIndexChanged" 
         >
        <ItemTemplate>
            control_id:
            <asp:Label ID="control_idLabel" runat="server" 
                Text='<%# Eval("control_id") %>' />
            <br />
            name:
            <asp:Label ID="nameLabel" runat="server" Text='<%# Eval("name") %>' />
            <br />
            email:
            <asp:Label ID="emailLabel" runat="server" Text='<%# Eval("email") %>' />
            <br />
            contactno:
            <asp:Label ID="contactnoLabel" runat="server" Text='<%# Eval("contactno") %>' />
            <br />
            address:
            <asp:Label ID="addressLabel" runat="server" Text='<%# Eval("address") %>' />
            <br />
            
<asp:Button ID="btnSelect" runat="server" CommandName="Select" Text="Select" />
        </ItemTemplate>
    </asp:DataList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:masterConnectionString %>" 
        SelectCommand="SELECT * FROM [students]"></asp:SqlDataSource>
    </form>
</body>
</html>
