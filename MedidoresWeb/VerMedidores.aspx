<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="VerMedidores.aspx.cs" Inherits="MedidoresWeb.VerMedidores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Yuna" runat="server">

    <div class="row">
        <div class="col-lg-8 mx-auto">
            <div class="card">
                <div class="card-header bg-success text-white">
                    <h2>Ver Medidores</h2>
                </div>
                <div class="card-body bg-dark">

                <div class=" form-group bg-dark">
                        <asp:DropDownList AutoPostBack="true" runat="server" ID="filtroDdl" 
                            OnSelectedIndexChanged="filtroDdl_SelectedIndexChanged" CssClass="form-control bg-dark text-white">
                            <asp:ListItem Text="Seleccione Tipo Medidor"> </asp:ListItem>
                            <asp:ListItem Value="inteligente" Text="inteligente"></asp:ListItem>
                            <asp:ListItem Value="clasico" Text="clasico"></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <asp:GridView runat="server" ID="grillaRescates" AutoGenerateColumns="false"
                            EmptyDataText="No hay medidores registrados" ShowHeader="true"
                            CssClass="table table-dark text-white"
                            OnRowCommand="grillaRescates_RowCommand">
                            <Columns>
                                <asp:BoundField DataField="IdMedidor" HeaderText="ID MEDIDOR" />
                                <asp:BoundField DataField="Tipo" HeaderText="TIPO MEDIDOR" />
                            </Columns>
                        </asp:GridView>
                    </div>
                </div>
            </div>
        </div>
    </div>


</asp:Content>
