<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Feedback.aspx.cs" Inherits="Webpage.Feedback" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style> 
        h1 {
            text-align: center;
        }
        body
        {
            background-color: #eedfb0
        }
        .feedback{
            padding: 0 0 0 20px;
        }
        #submit {
            text-align: center;
        }
        header {
            display:block; border:solid 1px; top: 0; left: 0; width: 100%; background-color: #6699FF; padding: 5px;
        }

        nav a:visited,
        nav a:link {
            color: #000000; text-decoration: none;
        }

        nav > ul {
            display: inline;  padding: 0; text-align:left;
        }

        nav > ul > li {
            display: inline-block; list-style: none; margin: 0 5px 0 5px;
        }
        footer {
            padding: 10px;
        }
        #queries {
            padding: 0 0 30px 20px;
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
                    <li><a href="#">DETAILED PRODUCT</a></li>
                    <li><a href="https://localhost:44324/Feedback.aspx">FEEDBACK</a></li>
                </ul>
            </nav>
        </header>
        <div>
            <h1>My Webpage</h1>
        </div>
        <div>
            <hr />
            <h1>Feedback Form</h1>
            <hr />
        </div>
        <div>
            <p> Please fill out this form if you have any problems and feedback. We strive to improve ourselves with the feedback that you provide so we can give and provide a better service to you and our other customers. Thank you very much</p>
        </div>
        <div class="feedback" id="name">
            <h3>First Name*</h3><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <h3>Middle Name</h3><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <h3>Last Name*</h3><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <h3>Contact: Please fill in your mobile number or email address*</h3><asp:TextBox ID="TextBox4" runat="server" Width="256px"></asp:TextBox>
        </div>
        <div class="feedback" id="queries">
            <h3>Do you have any problems or queries?*</h3><asp:TextBox ID="TextBox6" runat="server" Height="161px" Width="609px"></asp:TextBox>
        </div>
        <div class="feedback" id="submit">
            <asp:Button ID="SubmitBtn" runat="server" Text="Submit" />
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
