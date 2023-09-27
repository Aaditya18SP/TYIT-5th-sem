<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

    <div id="div_display_all_students">
     <div style="display:flex; flex-direction:row">
     <h1>All Users</h1> 
     <h1 style="margin-left:auto"> <asp:HyperLink runat="server" ID="linkToGridView" NavigateUrl="~/CRUD_gridview.aspx"> Go to GridView</asp:HyperLink> </h1>
     </div>
     <asp:Label runat="server" ID="lbFetchMsg" />
     <br />
    <asp:ListBox runat="server" ID="lboxAllDetails" Width="100%"   Rows="10"
            onselectedindexchanged="lboxAllDetails_SelectedIndexChanged" AutoPostBack="true" />


<!-- This is done directly from the aspx file and not programmatically
    <!--DataSourceID="SqlDataSource1" 
            DataTextField="ctrl_id" DataValueField="ctrl_id"
    
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:masterConnectionString %>" 
            SelectCommand="SELECT * FROM [students]"></asp:SqlDataSource>

            -->

            <br />
            <br />
            <asp:Button runat="server" ID="btnFetch" text="Fetch Users" 
             />
    </div>

    <div id="div_display_specific_details">
    <h1> The Details of the user</h1>

    <asp:Label runat="server" ID="lbEditDeleteMsg" />
    <br />

    <!--CTRL ID-->
    <asp:Label runat="server" ID="lbforDispCtrlId" Text="Control id:"/>
    <br />
    <asp:TextBox runat="server" ID="tbDispCtrlId" Enabled="false" />
    <br />
    <br />


     <!--NAME-->
    <asp:Label runat="server" ID="lbforDispName" Text="Name:"/>
    <br />
    <asp:TextBox runat="server" ID="tbDispName" Enabled="false"/>
    <br />
    <br />

     <!--EMAIL-->
    <asp:Label runat="server" ID="lbforDispEmail" Text="Email:"/>
    <br />
    <asp:TextBox runat="server" ID="tbDispEmail" Enabled="false" />
    <br />
    <br />

     <!--PHONE-->
    <asp:Label runat="server" ID="lbforDispPhone" Text="Phone:"/>
    <br />
    <asp:TextBox runat="server" ID="tbDispPhone" Enabled="false"/>
    <br />

     <!--Address-->
    <asp:Label runat="server" ID="lbforDispAddress" Text="Address:"/>
    <br />
    <asp:TextBox runat="server" ID="tbDispAddress" TextMode="multiline"  Width="50%" Enabled="false" />
    <br />
    <br />

    <!--Edit Button-->
     <asp:Button runat="server" ID="btnEdit" Text="Edit" onclick="btnEdit_Click"/>

    <!--Save Button-->
    <asp:Button runat="server" ID="btnSave" Text="Save" UseSubmitBehavior="true" 
            style="margin-left:20px" visible="false" onclick="btnSave_Click"/>

    <!--Delete Button-->
    <asp:Button runat="server" ID="btnDelete" Text="Delete"
            style="margin-left:20px" onclick="btnDelete_Click"/>
    </div>

    <!--
    A single textbox to display all the details
    <div class="div_display_specific_details">

    <h1>Displaying details of user</h1>

    <asp:TextBox runat="server" TextMode="multiline" id="tbDisplayDetails"></asp:TextBox>
    
    </div>

    -->

    <div id="input_user_details">
    <h1> Enter Details to insert</h1>

    <asp:Label runat="server" ID="lbInsertMsg" />
    <br />

    <!--CTRL ID-->
    <asp:Label runat="server" ID="lbCtrlId" Text="Control id:"/>
    <br />
    <asp:TextBox runat="server" ID="tbCtrlId" />
    <br />
    <br />


     <!--NAME-->
    <asp:Label runat="server" ID="lbForName" Text="Name:"/>
    <br />
    <asp:TextBox runat="server" ID="tbName"/>
    <br />
    <br />

     <!--EMAIL-->
    <asp:Label runat="server" ID="lbForEmail" Text="Email:"/>
    <br />
    <asp:TextBox runat="server" ID="tbEmail" />
    <br />
    <br />

     <!--PHONE-->
    <asp:Label runat="server" ID="lbForPhone" Text="Phone:"/>
    <br />
    <asp:TextBox runat="server" ID="tbPhone" />
    <br />

     <!--Address-->
    <asp:Label runat="server" ID="lbForAddress" Text="Address:"/>
    <br />
    <asp:TextBox runat="server" ID="tbAddress" TextMode="multiline" Width="50%" />
    <br />
  
    <br />

    <!--Insert Button-->
    <asp:Button runat="server" ID="btnInsert" Text="Insert" onclick="btnInsert_Click" />
    </div>
    </form>
</body>
</html>
