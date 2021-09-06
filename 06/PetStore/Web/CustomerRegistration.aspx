<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="CustomerRegistration.aspx.cs" Inherits="Web.CustomerRegistration" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div>
            <h1>Cats Page</h1>
        </div>
    <div>
        <form>
          <div class="form-group row">
              <asp:Label for="tb_Name" ID="lbl_Name" runat="server" Text="Name" class="col-sm-2 col-form-label"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="tb_Name" runat="server" class="form-control" placeholder="Please enter the name of the cat"></asp:TextBox>
            </div>
          </div>
          <div class="form-group row">
              <asp:Label for="tb_email" ID="lbl_email" runat="server" Text="Email ID" class="col-sm-2 col-form-label"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="tb_email" runat="server" class="form-control" placeholder="Enter Your Email"></asp:TextBox>
            </div>
          </div>
            <div class="form-group row">
               <asp:Label for="tb_zipcode" ID="lbl_zipcode" runat="server" Text="Zip Code" class="col-sm-2 col-form-label"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="tb_zipcode" runat="server" class="form-control" placeholder="Enter Your zipcode"></asp:TextBox>
            </div>
          </div>
            <div class="form-group row">
                <asp:Label for="tb_username" ID="lbl_username" runat="server" Text="User Name" class="col-sm-2 col-form-label"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="tb_username" runat="server" class="form-control" placeholder="Enter Your Username"></asp:TextBox>
            </div>
            </div>
            <div class="form-group row">
                <asp:Label for="tb_password" ID="lbl_password" runat="server" Text="Password" class="col-sm-2 col-form-label" TextMode="Password"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="tb_password" runat="server" class="form-control" placeholder="Enter Your password"></asp:TextBox>
            </div>
            </div>
          <div class="form-group row">
            <div class="col-sm-10 offset-sm-2">
                <asp:Button ID="btn_Add" class="btn btn-primary" runat="server" Text="Add" OnClick="btn_Add_Click" />
            </div>
              <asp:GridView ID="gv_cats" runat="server" BackColor="WhiteSmoke"> </asp:GridView>
              
          </div>
            <asp:Label ID="lbl_Display" runat="server" Text=""></asp:Label>
    </form>
    </div>

</asp:Content>       

