<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"   CodeFile="ZondaF.aspx.cs" Inherits="ZondaF" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">


<h1 style="text-align:center; margin-bottom:15px;color:black;"> The Pagani Zonda</h1>

<asp:Image runat="server" GenerateEmptyAlternateText="true" ID="img_Zonda" Width="100%" ImageUrl="~/images/zonda.jpg"/>

<asp:Label runat="server" ID="tb_ZondaInfo"  BorderStyle="none" Width="100%" Font-Italic="true" Font-Size="Larger" ForeColor="Black" Enabled="false" Text="The Pagani Zonda was the compnay's first ever car. Launced at Geneva Motor Show way back in early 2000s, it was one of the underdogs at the event. Designed and engineered by Horacio Pagani, it took the world by storm. With an AMG V12 paired with the manual gearbox and covered in Carbon fiber it soon become a living legend of the generation. The AMG V12 roared on the outside while the interior felt like someone has visited an Art Muesuem. The leather quality, the dials , the gearbox all immersed the driver in its Italian experience. The musical engine is at the center of its success, instilling the driver with emotions they have never felt before." />

<br />
<br />
<asp:Label ID="lb_ZondaModels" runat="server" Text="Various models" Font-Bold="true" ForeColor="Black" />

<asp:BulletedList ID="bl_ZondaModels" runat="server" BulletStyle="LowerRoman">
<asp:ListItem value="Zonda"></asp:ListItem>
<asp:ListItem value="Zonda S"></asp:ListItem>
<asp:ListItem value="Zonda s 7.3"></asp:ListItem>
<asp:ListItem value="Zonda F"></asp:ListItem>
<asp:ListItem value="Zonda R"></asp:ListItem>
<asp:ListItem value="Zonda 760LH"></asp:ListItem>
<asp:ListItem value="Zonda 760RS"></asp:ListItem>
<asp:ListItem value="Zonda Cinque"></asp:ListItem>
<asp:ListItem value="Zonda Cinque Roadster"></asp:ListItem>
</asp:BulletedList>


<br />
<br />

<div>
<asp:Label ID="lb_YourFavModel" Text="Which model would be in your dream garage" runat="server" Font-Bold="true" ForeColor="Black"></asp:Label>
<asp:DropDownList ID="ddl_YourFavModel" AutoPostBack="true" BackColor="#CCFFFF" runat="server" > 
<asp:ListItem value="Zonda"></asp:ListItem>
<asp:ListItem value="Zonda S"></asp:ListItem>
<asp:ListItem value="Zonda s 7.3"></asp:ListItem>
<asp:ListItem value="Zonda F"></asp:ListItem>
<asp:ListItem value="Zonda R"></asp:ListItem>
<asp:ListItem value="Zonda 760LH"></asp:ListItem>
<asp:ListItem value="Zonda 760RS"></asp:ListItem>
<asp:ListItem value="Zonda Cinque"></asp:ListItem>
<asp:ListItem value="Zonda Cinque Roadster"></asp:ListItem>

</asp:DropDownList>

<br />
<br />

<asp:Label ID="lb_AnyExperiences" Text="Did you see a Zonda somewhere, How was the experience" runat="server" Font-Bold="true" ForeColor="Black"></asp:Label>
<asp:TextBox ID="tb_AnyExperiences" width="100%" TextMode="Multiline" runat="server"> </asp:TextBox>

</div>
<asp:Label ID="lb_Review" Text="How did you find the article" runat="server" Font-Bold="true" ForeColor="Black" AssociatedControlID="rb_LikedIt"/>
<br />
<asp:RadioButton ID="rb_LikedIt" runat="server" AutoPostBack="True" Text="I liked it" GroupName="rg_article_review"/>
<br />
<asp:RadioButton ID="rb_NotLikedIt" runat="server" AutoPostBack="True" Text="Could be better" GroupName="rg_article_review"/>

<br />
<br />

<div style="text-align:center">
<asp:Button ID="btn_Post" runat="server" Text="Post" width="25%" BackColor="ActiveBorder" Height="45px" ForeColor="White" ToolTip="Type your experience and select whether you liked the article or no and then post "/>

<asp:Button ID="Btn_Share" runat="server" Text="Share" width="25%" BackColor="DarkGreen"  Height="45px" ForeColor="White"/>
</div>
  </asp:Content>

