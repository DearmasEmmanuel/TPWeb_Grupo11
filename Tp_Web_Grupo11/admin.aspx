<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="Tp_Web_Grupo11.admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <asp:Button ID="btnNuevo" runat="server" OnClick="btnNuevo_Click" CssClass="btn btn-primary" Text="Nuevo" />
        <asp:GridView ID="dgvProductos" CssClass="table table-striped" DataKeyNames="Id" OnSelectedIndexChanged="dgvProductos_SelectedIndexChanged" runat="server" AutoGenerateColumns="false">

            <Columns>
                <asp:BoundField HeaderText="Id" DataField="Id" HeaderStyle-CssClass="oculto" ItemStyle-CssClass="oculto" />
                <asp:BoundField HeaderText="Codigo" DataField="Codigo" HeaderStyle-CssClass="oculto" ItemStyle-CssClass="oculto" />
                <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                <asp:BoundField HeaderText="Descripcion" DataField="Descripcion" />
                <asp:BoundField HeaderText="Marca" DataField="Marca.Descripcion" />
                <asp:BoundField HeaderText="Categoria" DataField="Categoria.Descripcion" />
                <asp:BoundField HeaderText="Precio" DataField="Precio" />
                <asp:TemplateField HeaderText="Imagen">
                    <ItemTemplate>
                        <asp:Literal ID="LiteralImagen" runat="server" Text='<%# Eval("Imagen[0].ImagenUrl", "<img src=\"{0}\" alt=\"Imagen\" class=\"img-fluid\" style=\"max-width: 100px;\" />") %>' />

                    </ItemTemplate>
                </asp:TemplateField>

                <asp:CommandField ShowSelectButton="true" SelectText="Seleccionar" HeaderText="Modificar/Eliminar" />

            </Columns>

        </asp:GridView>

    </div>

</asp:Content>
