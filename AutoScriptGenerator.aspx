<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AutoScriptGenerator.aspx.cs" Inherits="AutoScriptGenerator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .inline-div {
            display: inline-block;
            padding-right: 15px;
        }

        .footerclass {
            display: inline-block;
            padding-right: 15px;
            float: left;
            width: 314px;
        }
    </style>
</head>
<body>
    <form id="AutoScriptGeneratorForm" runat="server">
        <div>
            <div class="buttonclass">
                <asp:Button ID="btn_Parse" runat="server" Text="Parse" OnClick="btn_Parse_Click" />
            </div>
            <div class="inline-div">
                <p align="center">UI Element</p>
                <textarea id="txtArea_UIElement" cols="32" rows="20" runat="server"></textarea>
            </div>
            <div class="inline-div">
                <p align="center">UI Usage</p>
                <textarea id="txtArea_UIUsage" cols="32" rows="20" class="inline-txtarea" runat="server"></textarea>
            </div>
            <div class="inline-div">
                <p align="center">Actions</p>
                <textarea id="txtArea_Action" cols="32" rows="20" class="inline-txtarea" runat="server"></textarea>
            </div>
            <div style="display: inline-block;float:left; width: 858px;">
                <div class="footerclass">
                    <asp:Button ID="btn_CopyCSCode" runat="server" Text="Copy CS Code" />
                </div>
                <div class="footerclass">
                    <asp:Button ID="btn_GenerateCSFile" runat="server" Text="Generate CS File" />

                </div>
            </div>
        </div>

    </form>
</body>
</html>
