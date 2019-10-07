<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="VerLectura.aspx.cs" Inherits="MedidoresWeb.VerLectura" %>
<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Yuna" runat="server">
        <div class="row">
        <div class="col-lg-8 mx-auto">
            <div class="card">
                <div class="card-header bg-success text-white">
                    <h2>Ver Lecturas</h2>
                </div>
                <div class="card-body bg-dark">
                                               <div class="form-group">
                        <label for="medidoreDD1" >Seleccione id medidor</label>
                                                   <asp:Button ID="Button1" runat="server" Height="33px" OnClick="Button1_Click" Text="Button" Width="58px" />
        <asp:DropDownList runat="server" ID="medidoreDD1" CssClass="form-control" AutoPostBack="True" Height="50px" Width="500px"></asp:DropDownList>   
                    </div>

                    </div>

                    <div class="form-group">
                        <asp:Chart ID="Chart1" runat="server" OnLoad="Chart1_Load" Width="878px">
                            <series>
                                <asp:Series Name="Series1" ChartType="Line">
                                </asp:Series>
                            </series>
                            <chartareas>
                                <asp:ChartArea Name="ChartArea1">
                                </asp:ChartArea>
                            </chartareas>
                        </asp:Chart>
                    </div>
                </div>
            </div>
        </div>
</asp:Content>
