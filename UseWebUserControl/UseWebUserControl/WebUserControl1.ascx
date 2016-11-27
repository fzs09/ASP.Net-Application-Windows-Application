<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebUserControl1.ascx.cs" Inherits="UseWebUserControl.WebUserControl1" %>

<table>
    <tr>
        <td>
            Date of birth:
          <asp:TextBox ID="txtDOB" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:ImageButton ID="btnCalender" runat="server" Height="29px" ImageUrl="~/images/calender.jpg" OnClick="btnCalender_Click" Width="36px" />
        </td>
    </tr>
    <tr>
        <td>
            <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
        </td>
    </tr>
</table>