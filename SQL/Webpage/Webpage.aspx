<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Webpage.aspx.cs" Inherits="Webpage.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>My Webpage</title>
    <style>
        body {
            background-color: #c3c3c3
        }
        h1 {
            text-align: center; background-color: #ffd800; color: #0094ff; padding: 5px 0 5px 0;
        }
        .search {
            text-align: center; padding: 10px 0 10px 0;
        }
        * {
            margin: 0;
        }

        header {
            display:block; border:solid 1px; top: 0; left: 0; width: 100%; background-color: #6699FF; padding: 5px;
        }

        nav a:visited,
        nav a:link {
            color: #000000; text-decoration: none;
        }

        nav > ul {
            display: inline;  padding: 0;
        }

        nav > ul > li {
            display: inline-block; list-style: none; margin: 0 5px 0 5px;
        }
        footer {
            padding: 10px;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        
        <header>
            <nav>
                <ul>
                    <li><a href="https://localhost:44324/Webpage.aspx">HOME</a></li>
                    <li><a href="https://localhost:44324/Product_page.aspx">PRODUCTS</a></li>
                    <li><a href="https://localhost:44324/Location.aspx">LOCATION</a></li>
                    <li><a href="#">DETAILED PRODUCT PAGE</a></li>
                    <li><a href="https://localhost:44324/Feedback.aspx">FEEDBACK</a></li>
                </ul>
            </nav>
        </header>
        <main> 

        

        <div>   
            
            <h1> My Webpage </h1>
            <hr />
            <div class="search">
            <asp:TextBox ID="TextBox1" runat="server" Width="31%" Height="23px"></asp:TextBox><asp:Button ID="SearchBtn" runat="server" Text="Search" Height="23px" Width="8%"  />
            </div>
            <hr />  
            <div class ="buttons">
               
            <asp:Button ID="ProductBtn" runat="server" Text="PRODUCT" Height="33px" Width="25%" style="background-color: #6699FF" />

            <asp:Button ID="LocationBtn" runat="server" Text="LOCATION" Height="33px" Width="25%" style="background-color: #6699FF" />

            

            </div>
            <div>
            <p>This is the main body. The content of the product page is taken from the known database Northwind. 

            </p>
        </div>
            <hr />
        </div>
        <div>
            </main>
            <footer>    
                <nav>
                <ul>
                    <li><a href="https://localhost:44324/Webpage.aspx">HOME</a></li>
                    <li><a href="https://localhost:44324/Product_page.aspx">PRODUCTS</a></li>
                    <li><a href="https://localhost:44324/Location.aspx">LOCATION</a></li>
                    <li><a href="#">DETAILED PRODUCT PAGE</a></li>
                    <li><a href="https://localhost:44324/Feedback.aspx">FEEDBACK</a></li>
                </ul>
            </nav>
            </footer>
        </div>
    </form>
</body>
</html>
