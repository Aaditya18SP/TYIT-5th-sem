﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Prac4b</title>
</head>
<body>
 <form id="Form1" runat="server">
<div class="Ads" style="text-align:center">
 <asp:AdRotator ID="adCoke" KeywordFilter="cokead" runat="server" AdvertisementFile="~/coke_ads_xml.xml" Target="_blank"/>
 </div>
 <br />

 <div class="Ads" style="text-align:right; float:right;display:inline-flex; position:sticky;width: 10%;height:100%" >

  <asp:AdRotator ID="adVertical" runat="server"  AlternateTextField="Alternate text" 
         AdvertisementFile="~/vertical_ads_xml.xml" 
         onadcreated="adVertical_AdCreated"  />

 </div>

 <div class="content"> 

 <asp:TextBox id="tb_adDetails"  textmode="MultiLine" BorderStyle="None" width="300px" enabled="false" Rows="10" runat="server"></asp:TextBox>

 </div>
 
 </form>

</body>
</html>
