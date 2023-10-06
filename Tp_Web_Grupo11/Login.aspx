<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Tp_Web_Grupo11.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div class="container mt-5 mb-5">
   <div class="row">
    <div class="col-4"></div>
    <div class="col">
        
        
        <div class="mb-3">
            <label for="exampleInputEmail1" class="form-label">Usuario</label>
            <asp:TextBox ID="txtUsuario" CssClass="form-control" runat="server"></asp:TextBox>
            
        </div>
        <div class="mb-3">
            <label for="exampleInputPassword1" class="form-label">Contraseña</label>
            
            <asp:TextBox ID="TxtContraseña" class="form-control" runat="server"></asp:TextBox>

        </div>
        <div class="mb-3 form-check">
            <input type="checkbox" class="form-check-input" id="exampleCheck1">
            <label class="form-check-label" CssClass="form-control" for="exampleCheck1">Validacion de Persona</label>
            <p>-----------------------</p>
            <p>usuario:admin</p>
            <p>contraseña:1324</p>
        </div>

       
        <asp:Button ID="Button1" Onclick="Button1_Click" CssClass="btn btn-primary" runat="server" Text="Aceptar" />
    </div>
    <div class="col-4"></div>

</div>
</div>

</asp:Content>
