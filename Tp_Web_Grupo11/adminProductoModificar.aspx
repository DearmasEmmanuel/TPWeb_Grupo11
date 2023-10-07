<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="adminProductoModificar.aspx.cs" Inherits="Tp_Web_Grupo11.adminProductoModificar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <div class="container mt-5 mb-5">
     <div class="row">
         <div class="col-6">
             <div class="mb-3">
                 <label for="txtID" class="form-label">Codigo</label>
                 <asp:TextBox ID="TxtCodigo" CssClass="form-control" runat="server"></asp:TextBox>

             </div>

             <div class="mb-3">
                 <label for="txtNombre" class="form-label">Nombre</label>
                 <asp:TextBox ID="TxtNombre" CssClass="form-control" runat="server"></asp:TextBox>

             </div>

             <div class="mb-3">
                 <label for="txtDescripcion" class="form-label">Descripcion</label>
                 <asp:TextBox ID="TxtDescripcion" TextMode="MultiLine" CssClass="form-control" runat="server"></asp:TextBox>

             </div>
             <div class="mb-3">
                 <label for="txtMarca" class="form-label">Marca</label>
                 <asp:DropDownList ID="ddMarca" CssClass="form-select" runat="server"></asp:DropDownList>


             </div>
             <div class="mb-3">
                 <label for="txtCategoria" class="form-label">Categoria</label>
                 <asp:DropDownList ID="ddCategoria" CssClass="form-select" runat="server"></asp:DropDownList>


             </div>
             <div class="mb-3">
                 <label for="txtImagenUrl" class="form-label">Url Imagen</label>
                 <asp:TextBox ID="txtImagenUrl" CssClass="form-control" runat="server"></asp:TextBox>
                 
             </div>
           



             <div class="mb-3">
                 <label for="txtPrecio" class="form-label">Precio</label>
                 <asp:TextBox ID="TxtPrecio" CssClass="form-control" runat="server"></asp:TextBox>

             </div>

             <div class="mb-3">
                 <asp:Button ID="btnAceptar" OnClick="btnAceptar_Click" CssClass="btn btn-primary" runat="server" Text="Aceptar" />
                 <a href="admin.aspx" cssclass="btn btn-primary">Cancelar</a>
             </div>




         </div>
     </div>
 </div>
</asp:Content>
