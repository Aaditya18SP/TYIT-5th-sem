<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ASP.NET form validation</title>
</head>
<body style="padding:20px">

<div>
<h1 style="text-align:center;margin-bottom:10px"> Form Validation in ASP.NET</h1>

</div>
    <form id="form1" runat="server">

    <!-- Various form fields-->
    <!--Name-->
    <asp:Label ID="lbForName" runat="server" ForeColor="Black" Text="Name"></asp:Label>
    <br />
    <asp:TextBox ID="tbName" runat="server" Width="25%" 
        ontextchanged="tbName_TextChanged"></asp:TextBox>
    <br />
    <asp:RequiredFieldValidator ControlToValidate="tbName" ErrorMessage="This is a required field" Display="Dynamic" ForeColor="Red" runat="server"></asp:RequiredFieldValidator>

    <br />
    <br />

     <!-- Email-->
    <asp:Label ID="lbForEmail" runat="server" ForeColor="Black" Text="Email"></asp:Label>
     <br />
    <asp:TextBox ID="tbEmail" runat="server" Width="25%"></asp:TextBox>
    <br />
    <asp:RegularExpressionValidator runat="server" ControlToValidate="tbEmail" ValidationExpression="\S[a-zA-Z0-9]\S+@\S+.\S" Display="Dynamic" ErrorMessage="Enter a valid Email" ForeColor="Red"></asp:RegularExpressionValidator>
     <br />
    <br />

    <!-- Phone-->
    <asp:Label ID="lbForPhone" runat="server" ForeColor="Black" Text="Phone"></asp:Label>
     <br />
    <asp:TextBox ID="tbPhone" runat="server" Width="25%" MaxLength="10"></asp:TextBox>
    <br />
     <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="tbEmail" ValidationExpression="\d{10}" Display="Dynamic" ErrorMessage="Enter a valid Phone number" ForeColor="Red"></asp:RegularExpressionValidator>
     <br />
    <br />

    <!--Age-->
    <asp:Label ID="lbForAge" runat="server" ForeColor="Black" Text="Age"></asp:Label>
     <br />
     <asp:TextBox ID="tbAge" runat="server" Width="25%" TextMode="Number" ></asp:TextBox>
     <br />
     <asp:RangeValidator ControlToValidate="tbAge" Display="Dynamic" Type="Integer" MaximumValue="100" MinimumValue="10" ErrorMessage="Please enter a valid between 10 to 100 years" runat="server" ForeColor="Red" ></asp:RangeValidator>
      <br />
    <br />

    <!-- Password-->
    <asp:Label ID="lbForPassword" runat="server" ForeColor="Black" Text="Password"></asp:Label>
     <br />
    <asp:TextBox ID="tbPassword" runat="server" Width="25%" TextMode="Password"></asp:TextBox>
    <br />
    <asp:CustomValidator ID="cvalPassword" ControlToValidate="tbPassword" Display="Dynamic" 
        ClientValidationFunction="validatePassword"  runat="server" 
        ErrorMessage="Enter a valid password" onservervalidate="cvalPassword_ServerValidate" 
        ></asp:CustomValidator>
     <br />
    <br />

     <!-- Confirm Password-->
    <asp:Label ID="lbForConfirmPassword" runat="server" ForeColor="Black" Text="Confirm Password"></asp:Label>
     <br />
    <asp:TextBox ID="tbConfirmPassword" runat="server" Width="25%" 
        TextMode="Password" ></asp:TextBox>
     <br />
     <asp:CompareValidator runat="server" ControlToValidate="tbConfirmPassword" ControlToCompare="tbPassword" ErrorMessage="The passwords dont match" Operator="Equal" Type="String" ></asp:CompareValidator> <!--ValueToCompare= ""-->
     <br />

    <br />


    <!--Submit Button-->
    <asp:Button ID="btnSubmit" runat="server" Text="Submit" />
    
   
    </form>

    <script type="text/javascript">
        function validatePassword(source, arguments) {
        var regex=S+[a-zA-Z0-9][8];
        if (arguments.Value.matches(regex)) {
            arguments.IsValid = true;
        }
        else {
            arguments.IsValid = false;
        }
        }
    </script>
</body>
</html>
