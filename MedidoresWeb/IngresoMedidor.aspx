<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="IngresoMedidor.aspx.cs" Inherits="MedidoresWeb.IngresoMedidor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Yuna" runat="server">






        <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="mensajes">
                <asp:Label runat="server" ID="mensajeBtn" CssClass="text-success"></asp:Label>
            </div>
            <div class="card">
                <div class="card-header bg-dark text-white">
                    <h2>Ingreso de medidores</h2>
                </div>
                <div class="card-body bg-dark text-white">
                    <div class="form-group">
                        <label for="nombreCTxt">ID Medidor</label>
                        <asp:TextBox runat="server" ID="IdmedidorTxt" CssClass="form-control"></asp:TextBox>

                    </div>
                      <div class="form-group">
                        <label for="playaTxt">Tipo Medidor</label>
                        <asp:DropDownList runat="server" ID="tipomedidorDD1" CssClass="form-control">
                            <asp:ListItem Selected="True" Value="inteligente" Text="Inteligente"></asp:ListItem>
                            <asp:ListItem Value="clasico" Text="clasico"></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <asp:Button runat="server" ID="agregarBtn" OnClick="agregarBtn_Click"
                            Text="Agregar" CssClass="btn btn-success btn-lg" />
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
