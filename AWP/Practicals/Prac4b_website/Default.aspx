<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
<div class="Ads" style="text-align:center">
 <asp:AdRotator ID="adCars" runat="server" AdvertisementFile="~/adrotator_ad_xml.xml"/>
 </div>
 <br />

 <div class="Ads" style="text-align:left" >
  <asp:AdRotator ID="adShoes" runat="server" AdvertisementFile="~/ad_new.xml" AlternateTextField="Alternate text" NavigateUrlField="https://"/>
 </div>
 <div class="content">

 </div>
</body>
</html>
