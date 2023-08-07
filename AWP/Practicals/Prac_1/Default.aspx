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
        Width="25%" Height="30px" ></asp:TextBox>
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
         <!--TextBox To display the selected engien type-->
    <asp:TextBox ID="tbOptionalExtras" BackColor="#cbecf7" runat="server" Visible="false" TextMode="MultiLine" Wrap="true"></asp:TextBox>
    
    <br />
    <br />
    <br />

    <!--Agree to the terms and conditions-->
    <asp:Label ID="lbReadNotReadTC" Visible="true" runat="server" ForeColor="Black" Text="Read the TC?"></asp:Label>
    <br />
  
        <!--Read the terms of conditons-->
        <asp:RadioButton ID="rbReadTC" AutoPostBack="true" 
        Text="I have read the terms of conditions" runat="server" 
        oncheckedchanged="rbReadTC_CheckedChanged" />

        <br />
        

        <asp:RadioButton ID="rbNotReadTC" AutoPostBack="true" Text="I have not read the terms of conditions" runat="server" />
        <br />
        <br />

        
        <!--Agree to terms of codntions-->
         <asp:Label ID="lbAgreeNotAgreeTC" Visible="true" runat="server" ForeColor="Black" Text="Agree to the TC?"></asp:Label>
         <br />
  

        <asp:CheckBox ID="cbAgreeTC" AutoPostBack="true" Text="I agree to the TC" runat="server" />

         <br />
        

         <asp:CheckBox ID="cbNotAgreeTC" AutoPostBack="true" Text="I do not agree to the TC" runat="server" />


          <br />
    <br />
    <br />


    <!--Submit Button-->
    <asp:Button ID="btnSubmit" BackColor="#0099CC" ForeColor="White"  Text="Submit" 
        runat="server" onclick="btnSubmit_Click" Enabled="false"/>

        <!--Clear Button-->
    <asp:Button ID="btnReset" BackColor="#d10210" ForeColor="White"  Text="Reset" 
        runat="server" onclick="btnSubmit_Reset" />


</asp:Content>
