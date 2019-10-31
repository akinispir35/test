<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="downlist.aspx.cs" Inherits="Kirtasiye.downlist" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 600px;
        }
        .auto-style2 {
            width: 95px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table cellpadding="0" cellspacing="0" class="auto-style1">
                <tr>
                    <td class="auto-style2">Musteri Ad</td>
                    <td>
                        <asp:TextBox ID="MusteriAd" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Şehir</td>
                    <td>
            <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">MusteriTipi</td>
                    <td>
                        <asp:TextBox ID="MusteriTip" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </div>
        <asp:Label ID="Label1" runat="server" Text="" Visible="False"></asp:Label>
    </form>
</body>
</html>
