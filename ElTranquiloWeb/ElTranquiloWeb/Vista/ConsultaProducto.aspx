<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ConsultaProducto.aspx.cs" Inherits="ElTranquiloWeb.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2 class="text-center">
    <br />
    <asp:Label ID="Label1" runat="server" Text="Consulta Productos"></asp:Label>
</h2>
<p>
    &nbsp;</p>
<p>
    Código:&nbsp;&nbsp;
    <asp:DropDownList ID="cbCodigo" runat="server" DataSourceID="SqlDataCbCodigoProducto" DataTextField="COD_PRODUCTO" DataValueField="COD_PRODUCTO" Width="179px" OnSelectedIndexChanged="btConsultar_Click">
    </asp:DropDownList>
    <asp:SqlDataSource ID="SqlDataCbCodigoProducto" runat="server" ConnectionString="<%$ ConnectionStrings:db20030ConsultaProducto %>" ProviderName="<%$ ConnectionStrings:db20030ConsultaProducto.ProviderName %>" SelectCommand="SELECT [COD_PRODUCTO] FROM [PRODUCTO]"></asp:SqlDataSource>
</p>
<p>
    Nombre:&nbsp;
    <asp:TextBox ID="txNombre" runat="server" Width="261px" ReadOnly="True"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btConsultar" runat="server" OnClick="btConsultar_Click" Text="Consultar" Width="146px" BackColor="#33CCCC" BorderColor="White" />
</p>
<p>
    Precio:&nbsp;
    <asp:TextBox ID="txPrecio" runat="server" Width="280px" ReadOnly="True"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</p>
<p>
    Stock:&nbsp;&nbsp;
    <asp:TextBox ID="txStock" runat="server" Width="278px" ReadOnly="True"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btLimpiar" runat="server" Text="Limpiar" Width="139px" OnClick="btLimpiar_Click" BackColor="#33CCCC" BorderColor="White" />
</p>
<p>
    Nit_Proveedor:&nbsp;
    <asp:TextBox ID="txNitProveedor" runat="server" Width="218px" ReadOnly="True"></asp:TextBox>
</p>
<p style="font-family: 'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif">
</p>
<p>
</p>
<p>
</p>
</asp:Content>
