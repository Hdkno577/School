<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Menu </title>
</head>
<body style="background-color:lightcoral">
    <center><a href="HtmlPage1.html">Homepage</a></center>
    <center><h1>Menu</h1></center>
    <form id="form1" runat="server">
 <center>
     <table border="1">
         <tr>
             <th width="150" height="30" style="background-color:darkolivegreen"><center><h2>Main Meals</h2></center></th>
             <th width="150" height="30" style="background-color:darkolivegreen"><center><h2>Sides</h2></center></th>
             <th width="150" height="30" style="background-color:darkolivegreen"><center><h2>Drinks</h2></center></th>
         </tr>
         <tr>
             <td width="150"><center><img src="burger.jpeg.jfif" width="150" height="150" /></center></td>
             <td width="150"><center><img src="Fries.jfif" width="150" height="150" /></center></td>
             <td width="150"><center></center><img src="coke.jfif" width="150" height="150" /></td>
         </tr>
         <tr>
             <th style="background-color:darkcyan"><center><h3>Cheeseburger $5.00</h3>
                 <p>Amount<asp:TextBox ID="CBbox" runat="server"></asp:TextBox>
                 </p></center></th>
             <th style="background-color:darkcyan"><center><h3>Fries $3.00</h3>
                 <p>Amount<asp:TextBox ID="friebox" runat="server"></asp:TextBox>
                 </p></center></th>
             <th style="background-color:darkcyan"><center><h3>Coke $1.50</h3>
                 <p>Amount<asp:TextBox ID="cokebox" runat="server"></asp:TextBox>
                 </p></center></th>
         </tr>
         <tr>
             <td width="150"><center><img src="CHsandwich.jfif" width="150" height="150" /></center></td>
             <td width="150"><center><img src="tots.jfif" width="150" height="150" /></center></td>
             <td width="150"><center><img src="MntDew.jfif" width="150" height="150" /></center></td>
         </tr>
         <tr>
             <th style="background-color:darkcyan"><center><h3>Chicken Sandwich $5.00</h3>
                 <p>Amount<asp:TextBox ID="CHbox" runat="server"></asp:TextBox>
                 </p></center></th>
             <th style="background-color:darkcyan"><center><h3>Tater Tots $3.00</h3>
                 <p>Amount<asp:TextBox ID="totbox" runat="server"></asp:TextBox>
                 </p></center></th>
             <th style="background-color:darkcyan"><center><h3>MntDew $1.50</h3>
                 <p>Amount<asp:TextBox ID="MDbox" runat="server"></asp:TextBox>
                 </p></center></th>
         </tr>
         <tr>
             <td width="150"><center><img src="tendies.jfif" width="150" height="150" /></center></td>
             <td width="150"><center><img src="salad.jfif" width="150" height="150" /></center></td>
             <td width="150"><center><img src="dp.jfif" width="150" height="150" /></center></td>
         </tr>
         <tr>
             <th style="background-color:darkcyan"><center><h3>Chicken Tenders $3.50</h3>
                 <p>Amount<asp:TextBox ID="tenderbox" runat="server"></asp:TextBox>
                 </p></center></th>
             <th style="background-color:darkcyan"><center><h3>Salad $1.50</h3>
                 <p>Amount<asp:TextBox ID="saladbox" runat="server"></asp:TextBox>
                 </p></center></th>
             <th style="background-color:darkcyan"><center><h3>Dr Pepper $1.50</h3>
                 <p>Amount<asp:TextBox ID="DPbox" runat="server"></asp:TextBox>
                 </p></center></th>
         </tr>
         <tr>
             <td width="150"><center><img src="Pizza.jfif" width="150" height="150" /></center></td>
             <td width="150"><center><img src="Nachos.jfif" width="150" height="150" /></center></td>
             <td width="150"><center><img src="fanta2.jfif" width="150" height="150" /></center></td>
         </tr>
         <tr>
             <th style="background-color:darkcyan"><center><h3>Pizza $3.00</h3>
                 <p>Amount<asp:TextBox ID="pizzabox" runat="server"></asp:TextBox>
                 </p></center></th>
             <th style="background-color:darkcyan"><center><h3>Nachos $2.50</h3>
                 <p>Amount<asp:TextBox ID="nachobox" runat="server"></asp:TextBox>
                 </p></center></th>
             <th style="background-color:darkcyan"><center><h3>Fanta $1.50</h3>
                 <p>Amount<asp:TextBox ID="fantabox" runat="server"></asp:TextBox>
                 </p></center></th>
         </tr>
         <tr>
             <td>&nbsp;</td>
         </tr>
     </table>
</center>
        <p>
            <asp:Button ID="calculateButton" runat="server" style="z-index: 1; left: 10px; top: 1092px; position: absolute" Text="Calculate" />
            <asp:Label ID="totallabel" runat="server" Text="Total"></asp:Label>
        </p>
    </form>
</body>
</html>
