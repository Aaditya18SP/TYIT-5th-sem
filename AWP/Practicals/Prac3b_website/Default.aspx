<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Prac3b4b</title>
</head>
<body>
 <form id="Form1" runat="server">

 <!--CALENDAR CONTROL-->
 <div class="content">



 <h1> Calendar control </h1>

 <!--Calendar control should be inside the form tag with \run at\ =server-->


 <asp:Calendar id="calNew" runat="server" 
         Caption="This is a caption for the calendar" CaptionAlign="Bottom" 
         DayNameFormat="Full" selectionmode="DayWeek" NextMonthText="Go_next" 
         PrevMonthText="Go_prev" onselectionchanged="calNew_SelectionChanged" 
         ondayrender="calNew_DayRender" DayHeaderStyle-Font-Bold="True" DayStyle-Font-Italic="true"
         NextPrevStyle-ForeColor="Red" OtherMonthDayStyle-ForeColor="Gray" NextPrevFormat="CustomText" />


 <asp:TextBox id="tb_calDetails" runat="server" Rows="10" Width="100%" ></asp:TextBox>
  </div>
 </form>

</body>
</html>
