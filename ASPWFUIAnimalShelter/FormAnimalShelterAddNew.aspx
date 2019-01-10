<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormAnimalShelterAddNew.aspx.cs" Inherits="ASPWFUIAnimalShelter.FormAnimalShelterAddNew" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title>Add new animal</title>
   <link href="Content/bootstrap.min.css" rel="stylesheet" />
   <script src="Scripts/jquery-ui-1.12.1.min.js"></script>
   <script src="Scripts/jquery-3.0.0.min.js"></script>
   <link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css"/>
   <link rel="stylesheet" href="/resources/demos/style.css"/>
   <script src="https://code.jquery.com/jquery-1.12.4.js"></script>
   <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
   <script>
    $(function() {
     $("#textBoxDateOfBirth").datepicker();
    } );
  </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>Animal Shelter Form</p>
            <table>
                <tr>
                    <td>Name: </td>
                    <td><asp:TextBox ID="textBoxName" runat="server" class="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="textBoxName" ErrorMessage="This field is required"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Species: </td>
                    <td><asp:TextBox ID="textBoxSpecies" runat="server" class="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="textBoxSpecies" ErrorMessage="This field is required"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Weight: </td>
                    <td><asp:TextBox ID="textBoxWeight" TextMode="Number" class="form-control" runat="server" min="0" max="500" step="1"/>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="textBoxWeight" ErrorMessage="This field is required"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Date Of Birth: </td>
                    <td><asp:TextBox ID="textBoxDateOfBirth" runat="server" class="datepicker-field form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="textBoxDateOfBirth" ErrorMessage="This field is required"></asp:RequiredFieldValidator>
                   </td>
                </tr>
            </table>
            <br />
            <asp:Button ID="buttonAdd" runat="server" OnClick="buttonAdd_Click" class="btn" Text="Add animal" />
        </div>
    </form>
</body>
</html>
