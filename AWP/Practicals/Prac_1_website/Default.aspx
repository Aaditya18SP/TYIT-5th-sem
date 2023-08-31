<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Welcome to ASP.NET!
    </h2>
    <p>
        To learn more about ASP.NET visit <a href="http://www.asp.net" title="ASP.NET Website">
            www.asp.net</a>.
    </p>
    <p>
        You can also find <a href="http://go.microsoft.com/fwlink/?LinkID=152368&amp;clcid=0x409"
            title="MSDN ASP.NET Docs">documentation on ASP.NET at MSDN</a>.
    </p>


    <!--General Description-->
    <asp:TextBox ID="tbDGeneralDesc" BackColor="#cbecf7" ToolTip="198 mph" BorderStyle="None"
        Width="100%" Height="30px" runat="server" ReadOnly="true" Text="Welcome! Have fun sharing your passion for cars with us. This is an online community of petrol head where we share our thoughts on the some of your favourite cars. Start by entering the following details" Wrap="true" Rows="5" TextMode="MultiLine" Font-Bold="true"></asp:TextBox>
    <br />
    <br />
    <br />

    <!-- Name-->
    <asp:Label ID="lbName" Visible="true" runat="server" ForeColor="Black" Text="Enter your name:"></asp:Label>
    <br />
    <br />
    <asp:TextBox ID="tbName" BackColor="#cbecf7" runat="server" TabIndex="1" AccessKey="A"
        AutoCompleteType="FirstName" ToolTip="Please enter your full name" BorderStyle="None"
        Width="25%" Height="30px" ontextchanged="tbName_TextChanged" ></asp:TextBox>
    <br />
    <br />
    <br />


    <!--Fav car-->
    <asp:Label ID="lbFavCar" Visible="true" runat="server" ForeColor="Black" Text="Enter your favorite car"></asp:Label>
    <br />
    <br />
    <asp:TextBox ID="tbFavCar" BackColor="#cbecf7" ToolTip="eg:Porsche 992 GT3" BorderStyle="None"
        Width="25%" Height="30px" runat="server"></asp:TextBox>
    <br />
    <br />
    <br />

     <!--Top Speed-->
    <asp:Label ID="lbTopSpeed" Visible="true" runat="server" ForeColor="Black" Text="Top Speed"></asp:Label>
    <br />
    <br />
    <asp:TextBox ID="tbTopSpeed" BackColor="#cbecf7" ToolTip="198 mph" BorderStyle="None"
        Width="25%" Height="30px" runat="server" MaxLength="7"></asp:TextBox>
    <br />
    <br />
    <br />


    <!--Engine Radiobutton-->

    <asp:Label ID="lbEngineType" Visible="true" runat="server" ForeColor="Black" Text="Engine"></asp:Label>
    <br />
    <br />

    <asp:RadioButtonList ID="rblCarEngine" runat="server" OnSelectedIndexChanged="rblCarEngine_SelectedIndexChanged" AutoPostBack="true">
       <asp:ListItem Value="V8" Text="V8"></asp:ListItem>
    <asp:ListItem Value="V10" Text="V10"></asp:ListItem>
    <asp:ListItem Value="V12" Text="V12"></asp:ListItem>
    <asp:ListItem Value="W12" Text="W12"></asp:ListItem>
      <asp:ListItem Value="W16" Text="W16"></asp:ListItem>
    
    </asp:RadioButtonList>

  
    <br />
    <br />
    <br />

    <!--TextBox To display the selected engien type-->
    <asp:TextBox ID="tbSelectedEngine" BackColor="#cbecf7" runat="server" Visible="false" TextMode="MultiLine" Wrap="true"></asp:TextBox>
    
    <br />
    <br />
    <br />

    <!--CheckBoxList Features-->
 <asp:Label ID="lbFeatures" Visible="true" runat="server" ForeColor="Black" Text="Optional Extras"></asp:Label>
    <br />
    <br />

    <asp:CheckBoxList runat="server" ID="cblFeatures" AutoPostBack="true" 
        onselectedindexchanged="cblFeatures_SelectedIndexChanged">
    <asp:ListItem Value="Carbon ceramic brakes" Text="Carbon ceramic brakes"></asp:ListItem>
    <asp:ListItem Value="ABS" Text="ABS"></asp:ListItem>
    <asp:ListItem Value="Lift System" Text="Lift System"></asp:ListItem>
    </asp:CheckBoxList>

     <br />
      <br />
       <br />
         <!--TextBox To display the selected engine type-->
    <asp:TextBox ID="tbOptionalExtras" BackColor="#cbecf7" runat="server" Visible="false" TextMode="MultiLine" Wrap="true"></asp:TextBox>
    
    <br />
    <br />
    <br />

    
       <!--Drop Down List of car brands-->

       <asp:Label ID="lbDropDownList" runat="server" Text="Car Brands" ForeColor="Black"></asp:Label>
       <br /> 
       <asp:DropDownList ID="ddlCarBrands" runat="server" 
         OnSelectedIndexChanged="ddlCarBrands_SelectedIndexChanged" AutoPostBack="true">
     
 <asp:ListItem >Pagani</asp:ListItem>
        <asp:ListItem >Koenigsegg</asp:ListItem>
         <asp:ListItem >Porsche</asp:ListItem>
          <asp:ListItem >Ferrari</asp:ListItem>
           <asp:ListItem >Mclaren</asp:ListItem>
       </asp:DropDownList>

       <br />
 <br />
        <br />
       <!--Bulleted list of that car brand-->

        <asp:Label ID="lbBulletedList" runat="server" Text="Car brands" ForeColor="Black"></asp:Label>  

        <br />
       <asp:BulletedList ID="blCarModels" BulletStyle="Numbered" runat="server" 
        ForeColor="Black" DisplayMode="HyperLink" Target="_blank" 
        >
        
       </asp:BulletedList>

        <br />
 <br />
        <br />

   
    <!--Agree to the terms and conditions-->
    <asp:Label ID="lbReadNotReadTC" Visible="true" runat="server" ForeColor="Black" Text="Read the TC?"></asp:Label>
    <br />
  
        <!--Read the terms of conditons-->
        <asp:RadioButton ID="rbReadTC" AutoPostBack="true" 
        Text="I have read the terms of conditions" runat="server" 
        oncheckedchanged="rbReadTC_CheckedChanged"   GroupName="TC"/>

        <br />
        

        <asp:RadioButton ID="rbNotReadTC" AutoPostBack="true" 
        Text="I have not read the terms of conditions" runat="server" 
        oncheckedchanged="rbNotReadTC_CheckedChanged" Checked="true" GroupName="TC" />
        <br />
        <br />

        
        <!--Agree to terms of conditions-->
         <asp:Label ID="lbAgreeNotAgreeTC" Visible="true" runat="server" ForeColor="Black" Text="Agree to the TC?"></asp:Label>
         <br />
  

        <asp:CheckBox ID="cbAgreeTC" AutoPostBack="true" Text="I agree to the TC" 
        runat="server" oncheckedchanged="cbAgreeTC_CheckedChanged" />

          <br />
    <br />
    <br />


    <!--Submit Button-->
    <asp:Button ID="btnSubmit" BackColor="#0099CC" ForeColor="White"  Text="Submit" 
        runat="server" onclick="btnSubmit_Click" Enabled="false"/>

        <!--Clear Button-->
    <asp:Button ID="btnReset" BackColor="#d10210" ForeColor="White"  Text="Reset" 
        runat="server" onclick="btnSubmit_Reset" />


        <hr />
        <br />
         <br />
          <br />



         <!--ListBox to choose the see the contributors of the website-->

         <asp:Label ID="LbContributors" Visible="true" runat="server" ForeColor="Black" Text="Contributed to this website"></asp:Label>
         <br />


         <asp:ListBox ID="lboxContributors" runat="server" Width="123px" 
        AutoPostBack="true" 
         SelectionMode="Multiple" onselectedindexchanged="lboxContributors_SelectedIndexChanged"  >
         <asp:ListItem> ABC</asp:ListItem>
          <asp:ListItem> XYZ</asp:ListItem>
 <asp:ListItem> DEF</asp:ListItem>
 <asp:ListItem> FGH</asp:ListItem>
 <asp:ListItem> IJK</asp:ListItem>
           <asp:ListItem> LMN</asp:ListItem>
         </asp:ListBox>

         <br />
         <br />
         <asp:TextBox ID="tbAddNewContributor" runat="server" BackColor="White"></asp:TextBox>

         <asp:Button ID="btnAddContributor" runat="server" Text="Add" 
        onclick="btnAddContributor_Click"/>
         <asp:Button ID="btnRemoveContributor" runat="server" Text="RemoveItem" 
        onclick="btnRemoveContributor_Click"/>
         <asp:Button ID="btnClearList" runat="server" Text="Clear" 
        onclick="btnClearList_Click"/>
          <asp:Button ID="btnCount" runat="server" Text="Count" 
        onclick="btnCount_Click"/>

         <br />
         <asp:Label ID="lbCount" runat="server"></asp:Label>
         <br />
         
         <br />
         <br />
         <asp:Label ID="lbSelectedItems" runat="server" Text="Selected items" ForeColor="Black"></asp:Label>
         <br />
       <asp:TextBox ID="tbSelectedItem" runat="server"></asp:TextBox>

        <br />
 <br />
        <br />

</asp:Content>
