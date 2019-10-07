<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="IngresoLectura.aspx.cs" Inherits="MedidoresWeb.IngresoLectura" %>
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
                    <h2>Ingreso de lecturas</h2>
                </div>
                <div class="card-body bg-dark text-white">
                           <div class="form-group">
                        <label for="medidoreDD1">Seleccione id medidor</label>
                        <asp:DropDownList runat="server" ID="medidoreDD1" CssClass="form-control"></asp:DropDownList>
                    </div>

                     <div class="form-group">
                        <label for="nombreCTxt">Ingrese Consumo</label>
                        <asp:TextBox runat="server" ID="ConsumoTxt" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="ConsumoTxt" runat="server" ErrorMessage="Debe ingresar Consumo"></asp:RequiredFieldValidator>

                    </div>

                         <div class="form-group">
                        <label for="nombreCTxt">Ingrese Hora</label>
                        <asp:TextBox runat="server" ID="HoraTxt" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" CssClass="text-danger" ControlToValidate="HoraTxt" runat="server" ErrorMessage=""></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="RangeValidator1" CssClass="text-danger" ControlToValidate="HoraTxt" MinimumValue="00" MaximumValue="23" runat="server" ErrorMessage="Debe ingresar una hora valida "></asp:RangeValidator>
                    </div>

                      <div class="form-group">
                        <label for="nombreCTxt">Ingrese Minutos</label>
                        <asp:TextBox runat="server" ID="MinutosTxt" CssClass="form-control"></asp:TextBox>
                          <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="MinutosTxt" runat="server" ErrorMessage="Debe ingresar minutos correcto de 00-59"></asp:RequiredFieldValidator>
                          <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="MinutosTxt" MaximumValue="59" MinimumValue="00" ErrorMessage="RangeValidator"></asp:RangeValidator>
                    </div>

                 <div class="card-body bg-dark text-white">
                           <div class="form-group">  
                               <label for="medidoreDD1">Seleccione fecha</label>
                               <asp:Calendar ID="Calendar1" placeholder="MM/DD/YYYY" runat="server" BackColor="White" BorderColor="Black" DayNameFormat="Shortest" Font-Names="Times New Roman" Font-Size="10pt" ForeColor="Black" Height="220px" NextPrevFormat="FullMonth" OnSelectionChanged="Calendar1_SelectionChanged" TitleFormat="Month" Width="400px">
                                   <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" ForeColor="#333333" Height="10pt" />
                                   <DayStyle Width="14%" />
                                   <NextPrevStyle Font-Size="8pt" ForeColor="White" />
                                   <OtherMonthDayStyle ForeColor="#999999" />
                                   <SelectedDayStyle BackColor="#CC3333" ForeColor="White" />
                                   <SelectorStyle BackColor="#CCCCCC" Font-Bold="True" Font-Names="Verdana" Font-Size="8pt" ForeColor="#333333" Width="1%" />
                                   <TitleStyle BackColor="Black" Font-Bold="True" Font-Size="13pt" ForeColor="White" Height="14pt" />
                                   <TodayDayStyle BackColor="#CCCC99" />
                               </asp:Calendar>
                               <asp:Label ID="fechaTxt" runat="server" Font-Bold="True"></asp:Label>
                    </div>
                        <div class="form-group">
                        <asp:Button runat="server" ID="agregarBtn" OnClick="agregarBtn_Click"
                            Text="Agregar" CssClass="btn btn-success btn-lg" />
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>




</asp:Content>
