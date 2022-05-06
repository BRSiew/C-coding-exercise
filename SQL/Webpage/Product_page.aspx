<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Product_page.aspx.cs" Inherits="Webpage.Product_page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Product page | My Webpage</title>
    <style>
        body {
            background-color: #c3c3c3
        }
        h1 {
            text-align: center; background-color: #ffd800; color: #0094ff; padding: 5px 0 5px 0;
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

        <div> 
            <h1>Product Page</h1>
        </div>
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Search" OnClick="Button1_Click" />
        </div>
        <hr />
        <div>
            <p>Search for the product you need in the search box above. Further details will be provided upon specifying.</p>

        </div>
        <hr /> 
        <div>
           
            <asp:GridView ID="GridView1" runat="server">
               
            </asp:GridView> 

        </div>
    </form>
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

</body>
</html>
