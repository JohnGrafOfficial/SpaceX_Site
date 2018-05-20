<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Launches.aspx.cs" Inherits="SpaceXWebsite.Launches" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style>
        #launchesTable
        {
            margin:auto;
            padding: 8px;
            width: 80%;
            font-family:'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
        }
        #launchesTable tr:nth-child(even)
        {
            background-color: #f2f2f2;

        }

        #launchesTable th
        {
            background-color: #181c1f;
            color:white;

        }

        h1{
            text-align:center;
            font-family:'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif;
        }

        h3{
            text-align:center;
            font-family:'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif;
        }




    </style>
    <title>SpaceX Launches</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>SpaceX Launch Data</h1>
        <h3>2006 - Present</h3>

            <asp:Table runat="server" id="launchesTable" >
                <asp:TableHeaderRow>
                    <asp:TableHeaderCell>Launch Date</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Rocket Name</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Cargo Manifest</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Success</asp:TableHeaderCell>
                </asp:TableHeaderRow>
            </asp:Table>

        <br /><p>Made by John Graf, 2018</p>
    
    </form>
</body>
</html>
