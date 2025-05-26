<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MaestroDetalle.aspx.cs" Inherits="ElTranquiloWeb.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        &nbsp;</p>
    <h2 class="text-center">Proveedores - Producto</h2>
    <h3 style="margin-left: 40px"><strong>&nbsp;&nbsp;&nbsp;&nbsp; Seleccione el proveedor:</strong></h3>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:DropDownList ID="cbCodigoProdProve" runat="server" AutoPostBack="True" DataSourceID="SqlDataProductoProveedor" DataTextField="NOMBRE" DataValueField="NIT" Width="264px">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataProductoProveedor" runat="server" ConnectionString="<%$ ConnectionStrings:db20030ConsultaProducto %>" SelectCommand="SELECT [NIT], [NOMBRE] FROM [PROVEEDOR]"></asp:SqlDataSource>
    </p>
    <h3>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>Productos:&nbsp;</strong></h3>
    <p>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" DataKeyNames="COD_PRODUCTO" DataSourceID="SqlDatagvProductoProveedor" GridLines="None" Height="255px" Width="1002px">
            <Columns>
                <asp:BoundField DataField="COD_PRODUCTO" HeaderText="COD_PRODUCTO" ReadOnly="True" SortExpression="COD_PRODUCTO" />
                <asp:BoundField DataField="NOMBRE" HeaderText="NOMBRE" SortExpression="NOMBRE" />
                <asp:BoundField DataField="PRECIO" HeaderText="PRECIO" SortExpression="PRECIO" />
                <asp:BoundField DataField="STOCK" HeaderText="STOCK" SortExpression="STOCK" />
                <asp:BoundField DataField="NIT_PROVEEDOR" HeaderText="NIT_PROVEEDOR" SortExpression="NIT_PROVEEDOR" />
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
        <asp:SqlDataSource ID="SqlDatagvProductoProveedor" runat="server" ConnectionString="<%$ ConnectionStrings:db20030ConsultaProducto %>" SelectCommand="SELECT * FROM [PRODUCTO] WHERE ([NIT_PROVEEDOR] = @NIT_PROVEEDOR)">
            <SelectParameters>
                <asp:ControlParameter ControlID="cbCodigoProdProve" Name="NIT_PROVEEDOR" PropertyName="SelectedValue" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
        <div class="text-center">
        </div>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
