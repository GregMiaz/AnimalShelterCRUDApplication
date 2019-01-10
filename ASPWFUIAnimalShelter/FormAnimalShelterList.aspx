<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormAnimalShelterList.aspx.cs" Inherits="ASPWFUIAnimalShelter.FormAnimalShelterList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>Animal Shelter</p>
            <p>List of animals:</p>
            <br />
            <asp:GridView ID="gridViewAnimals" DataKeyNames="Id" runat="server" AllowSorting="True" AutoGenerateColumns="False" CssClass="table table-striped table-bordered table-condensed" OnSelectedIndexChanged="gridViewAnimals_SelectedIndexChanged" OnRowDeleting="gridViewAnimals_RowDeleting">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="Name" HeaderText="Name" />
                    <asp:BoundField DataField="Species" HeaderText="Species" />
                    <asp:BoundField DataField="Weight" HeaderText="Weight" />
                    <asp:BoundField DataField="DateOfBirth" HeaderText="Date of Birth" DataFormatString="{0:d}"/>
                    <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Details" ShowHeader="True" Text="Show details" />
                    <asp:ButtonField ButtonType="Button" CommandName="Delete" HeaderText="Delete" ShowHeader="True" Text="Delete animal" />
                </Columns>
                <FooterStyle BackColor="#CCCC99" />
                <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                <RowStyle BackColor="#F7F7DE" />
                <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#FBFBF2" />
                <SortedAscendingHeaderStyle BackColor="#848384" />
                <SortedDescendingCellStyle BackColor="#EAEAD3" />
                <SortedDescendingHeaderStyle BackColor="#575357" />
            </asp:GridView>

            <asp:Button ID="buttonAdd" runat="server" OnClick="buttonAdd_Click" Text="Add Animal" />
            <br />
            <br />
            <asp:Label ID="labelDetails" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="labelDeleteResult" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
