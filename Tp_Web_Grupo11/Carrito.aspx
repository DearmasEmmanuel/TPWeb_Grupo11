<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="Tp_Web_Grupo11.Carrito" %>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
    <div class="container mt-4">
        <asp:GridView ID="dgvCarrito" CssClass="table table-striped" runat="server"></asp:GridView>
    </div>

    <div class="container mt-4">
        <div class="row">
            <div class="col-md-6 offset-md-6">
                <div class="d-flex justify-content-between">
                    <span class="font-weight-bold">Cantidad Total:</span>
                    <asp:Label ID="lblCantidadTotal" runat="server" CssClass="font-weight-bold" Text="0" />
                </div>
                <div class="d-flex justify-content-between">
                    <span class="font-weight-bold">Precio Total:</span>
                    <asp:Label ID="lblPrecioTotal" runat="server" CssClass="font-weight-bold" Text="$0.00" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>

