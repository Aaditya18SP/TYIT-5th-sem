<%@ Page Title="" Language="C#" MasterPageFile="~/CustomMasterPage.master" AutoEventWireup="true" CodeFile="911s.aspx.cs" Inherits="_911s" Theme="MyThemeFolder" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server" >
<div style="position:relative">
<asp:Image runat="server" Height="100%" Width="100%" ImageUrl="https://www.motortrend.com/uploads/2023/08/2024-porsche-911-st-60th-anniversary-16.jpg?fit=around%7C875:492"/>
<asp:Label ID="Label1" runat="server" width="100%" Text="Celebrate 60 years with us! The all new 911 S/T." SkinID="whiteText" style="position:absolute;left:0px;bottom:0px;font-weight:bold;font-size:6em;" />
</div>
</asp:Content>

