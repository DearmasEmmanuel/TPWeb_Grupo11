<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Tp_Web_Grupo11.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
        <div id="carouselExampleCaptions" class="carousel slide">
            <div class="carousel-indicators">
                <button type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide-to="0" class="active" aria-current="true" aria-label="Slide 1"></button>
                <button type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide-to="1" aria-label="Slide 2"></button>
                <button type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide-to="2" aria-label="Slide 3"></button>
            </div>
            <div class="carousel-inner">
                <div class="carousel-item active">
                    <img src="https://upload.wikimedia.org/wikipedia/commons/thumb/5/5d/LOGO_1200X300_Generalcover.png/800px-LOGO_1200X300_Generalcover.png" class="d-block w-100" alt="...">
                    <div class="carousel-caption d-none d-md-block">
                        <h5>First slide label</h5>
                        <p>Some representative placeholder content for the first slide.</p>
                    </div>
                </div>
                <div class="carousel-item">
                    <img src="https://upload.wikimedia.org/wikipedia/commons/thumb/5/5d/LOGO_1200X300_Generalcover.png/800px-LOGO_1200X300_Generalcover.png" class="d-block w-100" alt="...">
                    <div class="carousel-caption d-none d-md-block">
                        <h5>Second slide label</h5>
                        <p>Some representative placeholder content for the second slide.</p>
                    </div>
                </div>
                <div class="carousel-item">
                    <img src="https://upload.wikimedia.org/wikipedia/commons/thumb/5/5d/LOGO_1200X300_Generalcover.png/800px-LOGO_1200X300_Generalcover.png" class="d-block w-100" alt="...">
                    <div class="carousel-caption d-none d-md-block">
                        <h5>Third slide label</h5>
                        <p>Some representative placeholder content for the third slide.</p>
                    </div>
                </div>
            </div>
            <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide="prev">
                <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                <span class="visually-hidden">Previous</span>
            </button>
            <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide="next">
                <span class="carousel-control-next-icon" aria-hidden="true"></span>
                <span class="visually-hidden">Next</span>
            </button>
        </div>

    
    <style>
        .oculto{
            display:none;
        }

    </style>

  <div class="container">  
  <asp:GridView ID="dgvProductos" CssClass="table table-striped" DataKeyNames="Id" OnSelectedIndexChanged="dgvProductos_SelectedIndexChanged" runat="server" AutoGenerateColumns="false">
<Columns>
    <asp:BoundField HeaderText="Id" DataField="Id" HeaderStyle-CssClass="oculto" ItemStyle-CssClass="oculto"/>
    <asp:BoundField HeaderText="Nombre"  DataField="Nombre" />
    <asp:BoundField HeaderText="Descripcion"  DataField="Descripcion" />
    <asp:BoundField HeaderText="Marca"  DataField="Marca" />
    <asp:BoundField HeaderText="Precio"  DataField="Precio" />
    <asp:BoundField HeaderText="Imagen"  DataField="Imagen" />
    
    

</Columns>



  </asp:GridView>
      </div>

<div class="container">
    <div class="row">
        <asp:Repeater ID="rptProductos" runat="server">
            <ItemTemplate>
                <div class="col-md-4">
                    <div class="card card-product mb-4">
                        <div class="card-body">
                    <div class="text-center position-relative">
                        <!-- Aquí puedes agregar un código para mostrar etiquetas como "Sale" si es necesario -->
                        <a href="#!">
                            <img src='<%# Eval("Imagen[0].ImagenUrl") %>' alt='<%# Eval("Nombre") %>'
                                class="mb-3 img-fluid">
                        </a>
                        <div class="card-product-action">
                            <a href="#!" class="btn-action" data-bs-toggle="modal" data-bs-target="#quickViewModal">
                                <i class="bi bi-eye" data-bs-toggle="tooltip" data-bs-html="true" title="Quick View"></i>
                            </a>
                            <a href="#!" class="btn-action" data-bs-toggle="tooltip" data-bs-html="true" title="Wishlist">
                                <i class="bi bi-heart"></i>
                            </a>
                            <a href="#!" class="btn-action" data-bs-toggle="tooltip" data-bs-html="true" title="Compare">
                                <i class="bi bi-arrow-left-right"></i>
                            </a>
                        </div>
                    </div>
                    <div class="text-small mb-1">
                        <a href="#!" class="text-decoration-none text-muted"><small>Snack & Munchies</small></a>
                    </div>
                    <h2 class="fs-6">
                        <a href="../../pages/shop-single.html" class="text-inherit text-decoration-none">
                            <%# Eval("Nombre") %>
                        </a>
                    </h2>
                    <div>
                        <small class="text-warning">
                            <i class="bi bi-star-fill"></i>
                            <i class="bi bi-star-fill"></i>
                            <i class="bi bi-star-fill"></i>
                            <i class="bi bi-star-fill"></i>
                            <i class="bi bi-star-half"></i>
                        </small>
                      
                    </div>
                    <div class="d-flex justify-content-between align-items-center mt-3">
                        <div>
                            <span class="text-dark">$<%# Eval("Precio") %></span>
                            
                        </div>
                        <div>
                            <a href="#!" class="btn btn-primary btn-sm">
                                <svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" viewBox="0 0 24 24"
                                    fill="none" stroke="currentColor" stroke-width="2" stroke-linecap="round"
                                    stroke-linejoin="round" class="feather feather-plus">
                                    <line x1="5" y1="12" x2="19" y2="12"></line>
                                </svg> Add
                            </a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </ItemTemplate>
</asp:Repeater>


        </div>

        <!-- Controles de carrusel -->
        <a class="carousel-control-prev" href="#productosCarousel" role="button" data-slide="prev">
            <span class="carousel-control-prev-icon" aria-hidden="true"></span>
            <span class="sr-only">Anterior</span>
        </a>
        <a class="carousel-control-next" href="#productosCarousel" role="button" data-slide="next">
            <span class="carousel-control-next-icon" aria-hidden="true"></span>
            <span class="sr-only">Siguiente</span>
        </a>
    </div>







</asp:Content>
