<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Feedback.aspx.cs" Inherits="Webpage.Feedback" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
    <link rel="stylesheet" href="css/custom.css" />
    <title></title>
    <style> 
        h1 {
            text-align: center;
        }
        body
        {
            background-color: #eedfb0;
            padding: 10px 0 20px 10px;
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
            padding: 10px 0 20px 10px;
        }
        .contact{
            padding: 10px 0 20px 10px;
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
        <div class="text">
            <p> Please fill out this form if you have any problems and feedback. We strive to improve ourselves with the feedback that you provide so we can give and provide a better service to you and our other customers. Thank you very much</p>
        </div>
        <div class="container-fluid">
            <div class="row">
       
            <div class="col">
                <p>First Name*</p><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </div>
            <div class="col">
                <p>Middle Name</p><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </div>
            <div class="col">
                <p>Last Name*</p><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </div>
                
            </div>
                </div>
        <div class ="contact">
            <p>Contact: Please fill in your mobile number or email address*</p><asp:TextBox ID="TextBox4" runat="server" Width="256px"></asp:TextBox>
        </div>
        <hr />
        <div class="row" id="rating">
            <p>Please rate what  your experience is when navigating this website.</p>
            <div class="col">
                <p>very dissatisfied</p>
                <asp:CheckBox ID="CheckBox1" runat="server" />
            </div>
                <div class="col">
                <p>dissatisfied</p>
                <asp:CheckBox ID="CheckBox2" runat="server" />
            </div>
            <div class="col">
                <p>neutral</p>
                <asp:CheckBox ID="CheckBox3" runat="server" />
            </div>
            <div class="col">
                <p>satisfied</p>
                <asp:CheckBox ID="CheckBox4" runat="server" />
            </div>
            <div class="col">
                <p>very satisfied</p>
                <asp:CheckBox ID="CheckBox5" runat="server" />
            </div>
            <hr />
        </div>
        <div class="feedback" id="queries">
            
            <p>Additional comments/problems?*</p><asp:TextBox ID="TextBox6" runat="server" Height="161px" Width="609px"></asp:TextBox>
        </div>
        <div class="feedback" id="submit">
            <asp:Button ID="SubmitBtn" runat="server" Text="Submit" />
        </div>

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
