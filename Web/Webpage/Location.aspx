<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Location.aspx.cs" Inherits="Webpage.Location" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Location | My Webpage</title>
</head>
    <style>
       
        h1 {
            text-align: center; background-color: #ffd800; color: #0094ff; padding: 5px 0 5px 0;
        }
        body{
            display:flex; justify-content:center; background-color: #c3c3c3
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
            <h1>Contact Us</h1>
            <p>Mobile: 1235456789</p>
            <p>Email address: bcde@someemail.com</p>
        </div>
        <div>
            <div>you can vist to this map location of a place</div>
            <iframe src="https://www.google.com/maps/embed?pb=!1m10!1m8!1m3!1d2483.752596896119!2d-0.0969409!3d51.4994074!3m2!1i1024!2i768!4f13.1!5e0!3m2!1sen!2suk!4v1651836215697!5m2!1sen!2suk" width="600" height="450" style="border:0;" allowfullscreen="" loading="lazy" referrerpolicy="no-referrer-when-downgrade"></iframe>
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
