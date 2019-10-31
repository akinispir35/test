<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MusteriGuncelle.aspx.cs" Inherits="Kirtasiye.MusteriGuncelle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
  
<body>
      <style>
        table{
            font-family:'Times New Roman'
        }
    </style>
    <form id="form1" runat="server">
        <div>
            <table style="background-color:cornflowerblue">
                <tr>
                    
                    <td>Müşteri Id</td>
                    <td>
                        <asp:Label ID="MusteriId" runat="server"></asp:Label>
                    </td>
                    <td> <asp:Button ID="btnUpdate" runat="server" Text="Guncelle" OnClick="btnUpdate_Click" /></td>
                    <td></td>
                </tr>
                <tr>
                    
                    <td>Müşteri Adı</td>
                    <td><asp:TextBox ID="MusteriAd" runat="server"></asp:TextBox></td>
                    <td> <asp:Button ID="btnYenile" runat="server" Text="Yenile" OnClick="btnYenile_Click" Width="77px" /></td>
                    <td></td>
                </tr>
                <tr>
                    <td>Şehir</td>
                    <td> <asp:TextBox ID="Sehir" runat="server"></asp:TextBox></td>
                    <td> &nbsp;</td>
                    <td></td></tr>
                <tr>
                    <td>Müşteri Tipi</td>
                    <td><asp:TextBox ID="MusteriTip" runat="server" Width="90px"></asp:TextBox></td>
                    <td> &nbsp;</td>
                    <td>&nbsp;</td></tr>
                 <tr><td> &nbsp;</td></tr>
               <tr><td> <asp:Label ID="Label1" runat="server" Visible="False"></asp:Label></td></tr>
                

                <tr><td>&nbsp;</td></tr>
                 <tr><td><asp:Label ID="Label2" runat="server" Text=""></asp:Label></td></tr>   
             
            </table>
        </div>
    
        
        <div>
           
        </div>
           
            <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
           
    </form>
</body>
</html>

