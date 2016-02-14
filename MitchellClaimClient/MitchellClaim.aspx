<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MitchellClaim.aspx.cs" Inherits="MitchellClaimClient.MitchellClaim" EnableEventValidation="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Mitchell Claim 
    </title>
    <script type="text/javascript" src='http://ajax.googleapis.com/ajax/libs/jquery/1.7.1/jquery.min.js'></script>
    <script type="text/javascript" src=' http://ajax.googleapis.com/ajax/libs/jqueryui/1.8.14/jquery-ui.min.js '></script>
    <link rel="stylesheet" type="text/css" href="http://ajax.googleapis.com/ajax/libs/jqueryui/1.8.14/themes/base/jquery-ui.css"></link>
    <script src="MitchellClaim.js"></script>
    <style type="text/css">
        .Initial {
            display: block;
            float: left;
            color: Black;
            font-weight: bold;
        }

            .Initial:hover {
                color: coral;
            }

        .Clicked {
            background-color: gainsboro;
            float: left;
            display: block;
            color: Black;
            font-weight: bold;
        }
    </style>
</head>
<body style="font-family: tahoma; background-color:lightblue">
    <form id="form2" runat="server">
        <h2>Mitchell Claim operations
        </h2>
        <table>
            <tr>
                <td>
                    <asp:Button Text="Display Claim" ID="Tab1" CssClass="Initial" runat="server"
                        OnClick="Tab1_Click" />
                    <asp:Button Text="Add Claim" ID="Tab2" CssClass="Initial" runat="server"
                        OnClick="Tab2_Click" />
                    <asp:Button Text="View Claim" ID="Tab3" CssClass="Initial" runat="server"
                        OnClick="Tab3_Click" />
                    <asp:MultiView ID="MainView" runat="server">
                        <asp:View ID="View1" runat="server">
                            <table style="width: 100%; border-width: 1px; border-color: #666; border-style: solid">
                                <tr>
                                    <td>
                                        <div id="displayDiv">
                                            <h3>Display Claim
                                            </h3>
                                            <table>
                                                <tr>
                                                    <td>From Loss Date
                                                    </td>
                                                    <td>
                                                        <asp:TextBox runat="server" ID="txtFromDate"></asp:TextBox>
                                                    </td>
                                                    <td style="width: 200px; text-align: right">To Loss Date
                                                    </td>
                                                    <td>
                                                        <asp:TextBox runat="server" ID="txtToDate"></asp:TextBox>
                                                    </td>
                                                    <td style="width: 200px; text-align: right">
                                                        <asp:Button runat="server" Text="Refresh" ID="btnRefresh" OnClick="btnRefresh_Click" />
                                                    </td>
                                                </tr>
                                            </table>
                                            <p>
                                                Note: Click on Refresh to get list of Claims.
                                            </p>
                                            <div style="margin-left: 100px; margin-top: 50px">
                                                <br />
                                                <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="true" Width="185px" OnRowDataBound="GridView2_RowDataBound" OnSelectedIndexChanged="GridView2_SelectedIndexChanged">
                                                </asp:GridView>
                                            </div>
                                        </div>
                                    </td>
                                </tr>
                            </table>
                        </asp:View>
                        <asp:View ID="View2" runat="server">
                            <table style="width: 100%; border-width: 1px; border-color: #666; border-style: solid">
                                <tr>
                                    <td>
                                        <div id="AddDiv">
                                            <h3>Add a Claim
                                            </h3>
                                            <table>
                                                <tr>
                                                    <td>Claim Number
                                                    </td>
                                                    <td>
                                                        <asp:TextBox runat="server" ID="txtClaimNumber"></asp:TextBox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>ClaimantFirstName
                                                    </td>
                                                    <td>
                                                        <asp:TextBox runat="server" ID="txtFname"></asp:TextBox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>ClaimantLasttName
                                                    </td>
                                                    <td>
                                                        <asp:TextBox runat="server" ID="txtLname"></asp:TextBox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Status
                                                    </td>
                                                    <td>
                                                        <asp:DropDownList runat="server" ID="ddlStatus">
                                                            <asp:ListItem></asp:ListItem>
                                                            <asp:ListItem>OPEN</asp:ListItem>
                                                            <asp:ListItem>CLOSED</asp:ListItem>
                                                        </asp:DropDownList>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Loss date
                                                    </td>
                                                    <td>
                                                        <asp:TextBox runat="server" ID="lossDatePicker"></asp:TextBox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Assigned Adjuster ID
                                                    </td>
                                                    <td>
                                                        <asp:TextBox runat="server" ID="txtAdjusterId"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>

                                            <h4>Loss Information
                                            </h4>
                                            <table>
                                                <tr>
                                                    <td>Cause of Loss
                                                    </td>
                                                    <td>
                                                        <asp:DropDownList runat="server" ID="ddlLossCause">
                                                            <asp:ListItem></asp:ListItem>
                                                            <asp:ListItem>Collision</asp:ListItem>
                                                            <asp:ListItem>Explosion</asp:ListItem>
                                                            <asp:ListItem>Fire</asp:ListItem>
                                                            <asp:ListItem>Hail</asp:ListItem>
                                                            <asp:ListItem>Mechanical Breakdown</asp:ListItem>
                                                            <asp:ListItem>Other</asp:ListItem>
                                                        </asp:DropDownList>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Reported Date
                                                    </td>
                                                    <td>
                                                        <asp:TextBox runat="server" ID="txtreportedDate"></asp:TextBox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Loss Description
                                                    </td>
                                                    <td>
                                                        <asp:TextBox runat="server" ID="txtDescription"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                            <h4>Vehicle Information
                                            </h4>
                                            <div>
                                                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowCreated="Gridview1_RowCreated" ShowFooter="true">
                                                    <Columns>
                                                        <asp:TemplateField HeaderText="Model Year">
                                                            <ItemTemplate>
                                                                <asp:TextBox ID="txtYear" runat="server" Width="78px"></asp:TextBox>
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                        <asp:TemplateField HeaderText="Model Description">
                                                            <ItemTemplate>
                                                                <asp:TextBox ID="txtModel" runat="server"></asp:TextBox>
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                        <asp:TemplateField HeaderText="Engine Description">
                                                            <ItemTemplate>
                                                                <asp:TextBox ID="txtEngine" runat="server"></asp:TextBox>
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                        <asp:TemplateField HeaderText="Exterior Color">
                                                            <ItemTemplate>
                                                                <asp:TextBox ID="txtColor" runat="server" Width="97px"></asp:TextBox>
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                        <asp:TemplateField HeaderText="Vin">
                                                            <ItemTemplate>
                                                                <asp:TextBox ID="txtVin" runat="server" Width="40px"></asp:TextBox>
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                        <asp:TemplateField HeaderText="Lic Plate">
                                                            <ItemTemplate>
                                                                <asp:TextBox ID="txtLicPlate" runat="server" Width="57px"></asp:TextBox>
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                        <asp:TemplateField HeaderText="Lic Plate State">
                                                            <ItemTemplate>
                                                                <asp:TextBox ID="txtLicState" runat="server"></asp:TextBox>
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                        <asp:TemplateField HeaderText="Lic Plate ExpDate">
                                                            <ItemTemplate>
                                                                <asp:TextBox ID="txtLicExpDate" runat="server" CssClass="txtDate"></asp:TextBox>
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                        <asp:TemplateField HeaderText="Damage Description">
                                                            <ItemTemplate>
                                                                <asp:TextBox ID="txtDamage" runat="server"></asp:TextBox>
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                        <asp:TemplateField HeaderText="Mileage">
                                                            <ItemTemplate>
                                                                <asp:TextBox ID="txtMileage" runat="server"></asp:TextBox>
                                                            </ItemTemplate>
                                                            <FooterStyle HorizontalAlign="Right" />
                                                            <FooterTemplate>
                                                                <asp:Button ID="ButtonAdd" runat="server" Text="Save"
                                                                    OnClick="ButtonAdd_Click" />
                                                            </FooterTemplate>
                                                        </asp:TemplateField>
                                                        <asp:TemplateField>
                                                            <ItemTemplate>
                                                                <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Remove</asp:LinkButton>
                                                            </ItemTemplate>
                                                        </asp:TemplateField>
                                                    </Columns>
                                                </asp:GridView>
                                            </div>

                                            <br />
                                            <asp:Button runat="server" Text="Save" ID="btnSave" OnClick="btnSave_Click" />
                                        </div>
                                    </td>
                                </tr>
                            </table>
                        </asp:View>
                         <asp:View ID="View3" runat="server">
                            <table style="width: 100%; border-width: 1px; border-color: #666; border-style: solid">
                                <tr>
                                    <td>
                                        <div id="ViewDiv">
                                            <h3>View a Claim
                                            </h3>
                                            <table>
                                                <tr>
                                                    <td>Claim Number
                                                    </td>
                                                    <td>
                                                        <asp:TextBox runat="server" ID="txtClaimNumberView"></asp:TextBox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>ClaimantFirstName
                                                    </td>
                                                    <td>
                                                        <asp:TextBox runat="server" ID="txtFnameView"></asp:TextBox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>ClaimantLasttName
                                                    </td>
                                                    <td>
                                                        <asp:TextBox runat="server" ID="txtLnameView"></asp:TextBox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Status
                                                    </td>
                                                    <td>
                                                        <asp:DropDownList runat="server" ID="ddlStatusView">
                                                            <asp:ListItem></asp:ListItem>
                                                            <asp:ListItem>OPEN</asp:ListItem>
                                                            <asp:ListItem>CLOSED</asp:ListItem>
                                                        </asp:DropDownList>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Loss date
                                                    </td>
                                                    <td>
                                                        <asp:TextBox runat="server" ID="lossDatePickerView"></asp:TextBox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Assigned Adjuster ID
                                                    </td>
                                                    <td>
                                                        <asp:TextBox runat="server" ID="txtAdjusterIdView"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>

                                            <h4>Loss Information
                                            </h4>
                                            <table>
                                                <tr>
                                                    <td>Cause of Loss
                                                    </td>
                                                    <td>
                                                        <asp:DropDownList runat="server" ID="ddlLossCauseView">
                                                            <asp:ListItem></asp:ListItem>
                                                            <asp:ListItem>Collision</asp:ListItem>
                                                            <asp:ListItem>Explosion</asp:ListItem>
                                                            <asp:ListItem>Fire</asp:ListItem>
                                                            <asp:ListItem>Hail</asp:ListItem>
                                                            <asp:ListItem>Mechanical Breakdown</asp:ListItem>
                                                            <asp:ListItem>Other</asp:ListItem>
                                                        </asp:DropDownList>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Reported Date
                                                    </td>
                                                    <td>
                                                        <asp:TextBox runat="server" ID="txtreportedDateView"></asp:TextBox>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td>Loss Description
                                                    </td>
                                                    <td>
                                                        <asp:TextBox runat="server" ID="txtDescriptionView"></asp:TextBox>
                                                    </td>
                                                </tr>
                                            </table>
                                            <h4>Vehicle Information
                                            </h4>
                                            <div>
                                               <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="true">
                                                </asp:GridView>
                                            </div>
                                        </div>
                                    </td>
                                </tr>
                            </table>
                        </asp:View>
                    </asp:MultiView>
                </td>
            </tr>
        </table>
    </form>
</body>

</html>
