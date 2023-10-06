<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="Tp_Web_Grupo11.admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
     <style>
        /* Estilo para la barra lateral */
        .sidebar {
            height: 100%;
            width: 250px;
            position: fixed;
            top: 0;
            left: 0;
            background-color: #333;
            padding-top: 20px;
        }

        .sidebar a {
            padding: 15px;
            text-align: center;
            text-decoration: none;
            font-size: 20px;
            color: #fff;
            display: block;
        }

        .content {
            margin-left: 250px;
            padding: 20px;
        }
    </style>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="sidebar">
    <a href="#"><i class="fa fa-dashboard"></i> Dashboard</a>
    <a href="#"><i class="fa fa-users"></i> Usuarios</a>
    <a href="#"><i class="fa fa-cogs"></i> Configuración</a>
    <a href="Default.aspx"><i class="fa fa-sign-out"></i> Cerrar Sesión</a>
</div>

<!-- Contenido principal -->
<div class="content">
    <h1>Bienvenido al Panel de Administración</h1>
    <p>Este es un ejemplo de una página de administración con Bootstrap y Font Awesome.</p>
</div>

<!-- Enlaces a las bibliotecas Bootstrap y jQuery (opcional) -->
<script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
<script src="https://cdn.jsdelivr.net/npm/bootstrap/dist/js/bootstrap.min.js"></script>

 <div class="container">
 <asp:GridView ID="dgvProductos" CssClass="table table-striped" DataKeyNames="Id" OnSelectedIndexChanged="dgvProductos_SelectedIndexChanged" runat="server" AutoGenerateColumns="false">
 
<Columns>
    <asp:BoundField HeaderText="Id" DataField="Id" HeaderStyle-CssClass="oculto" ItemStyle-CssClass="oculto"/>
    <asp:BoundField HeaderText="Nombre"  DataField="Nombre" />
    <asp:BoundField HeaderText="Descripcion"  DataField="Descripcion" />
    <asp:BoundField HeaderText="Marca"  DataField="Marca" />
    <asp:BoundField HeaderText="Precio"  DataField="Precio" />
<asp:TemplateField HeaderText="Imagen">
            <ItemTemplate>
                <asp:Literal ID="LiteralImagen" runat="server" Text='<%# Eval("Imagen[0].ImagenUrl", "<img src=\"{0}\" alt=\"Imagen\" class=\"img-fluid\" style=\"max-width: 100px;\" />") %>' />

            </ItemTemplate>
        </asp:TemplateField>

   
    <asp:CommandField ShowSelectButton="true" SelectText="Seleccionar" HeaderText="Accion" />
    

</Columns>



  </asp:GridView>

</div>



</asp:Content>
