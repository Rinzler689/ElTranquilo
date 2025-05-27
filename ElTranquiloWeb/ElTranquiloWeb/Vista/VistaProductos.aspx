<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VistaProductos.aspx.cs" Inherits="ElTranquiloWeb.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2 class="text-center"><strong>
    <br />
    Tabla Productos Registrados</strong></h2>
<p>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" DataKeyNames="CODIGO PRODUCTO" DataSourceID="SqlDataVistaProductos" GridLines="None" Height="418px" Width="1120px">
        <Columns>
            <asp:BoundField DataField="CODIGO PRODUCTO" HeaderText="CODIGO PRODUCTO" ReadOnly="True" SortExpression="CODIGO PRODUCTO" />
            <asp:BoundField DataField="NOMBRE" HeaderText="NOMBRE" SortExpression="NOMBRE" />
            <asp:BoundField DataField="PRECIO" HeaderText="PRECIO" SortExpression="PRECIO" />
            <asp:BoundField DataField="STOCK" HeaderText="STOCK" SortExpression="STOCK" />
            <asp:BoundField DataField="NOMBRE PROVEEDOR" HeaderText="NOMBRE PROVEEDOR" SortExpression="NOMBRE PROVEEDOR" />
        </Columns>
        <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
        <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
        <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
        <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#594B9C" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#33276A" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataVistaProductos" runat="server" ConnectionString="<%$ ConnectionStrings:db20030ConsultaProducto %>" SelectCommand="SELECT * FROM [CONSULTA_PRODUCTOS]"></asp:SqlDataSource>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
</asp:Content>
