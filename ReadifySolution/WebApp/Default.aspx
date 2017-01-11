<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApp._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>Readify Knock Knock Challenge!</h1>
            </hgroup>
           
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h3>Operations:</h3>
    <ol class="round">
        <li >
            <h5>Fibonacci</h5>
           <br />
            <br />
            <asp:TextBox ID="txtVaulue" runat="server" ></asp:TextBox>
            <asp:Button runat="server" ID="btnClick" Text="Try it" OnClick="btnClick_Click" />
             <p>
            Value is : <asp:Label ID="lblValue" runat="server"></asp:Label>
        </p>
        </li>
       
    </ol>
</asp:Content>
