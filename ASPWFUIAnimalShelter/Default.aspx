<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ASPWFUIAnimalShelter.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Migration</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <asp:Label ID="labelTitle" runat="server" class="col-form-label" Text="Animal Shelter Data Migration"></asp:Label>
            <br />
            <br />
            <asp:Button ID="buttonCreateTable" runat="server" Text="Create Table" class="btn" OnClick="buttonCreateTable_Click" />
            <br />
            <br />
            <asp:Label ID="labelCreateTableMessage" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="labelFileLocalization" runat="server" Text="File localization:"></asp:Label>
            &nbsp;<asp:TextBox ID="TextBoxPath" class="form-control-sm" runat="server">Specify file path here</asp:TextBox>
            <br />
            <br />
            <asp:Button ID="buttonMigration" runat="server" Text="Start data migration" class="btn" OnClick="buttonMigration_Click" />
            <br />
            <br />
            <asp:Button ID="buttonShowAnimals" runat="server" Text="Show animals" class="btn" OnClick="buttonShowAnimals_Click" />
            <br />
            <br />
            <asp:Label ID="labelMigrationResult" runat="server" class="col-form-label" ></asp:Label>
        </div>
    </form>
</body>
</html>
