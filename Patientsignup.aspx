<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Patientsignup.aspx.cs" Inherits="Default2" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="acp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 301px;
        }

        .auto-style2 {
            width: 131px;
        }

        #form1 {
            height: 382px;
        }

        .auto-style3 {
            width: 131px;
            height: 26px;
        }

        .auto-style4 {
            height: 26px;
        }

        .auto-style5 {
            width: 131px;
            height: 27px;
        }

        .auto-style6 {
            height: 27px;
        }

        .auto-style7 {
            width: 131px;
            height: 28px;
        }

        .auto-style8 {
            height: 28px;
        }
        .auto-style9 {
            width: 70px;
            height: 30px;
        }
        .auto-style10 {
            width: 539px;
            height: 30px;
        }
        :-moz-placeholder {
   font-style: italic;  
}
::-moz-placeholder {
   font-style: italic;  
}
:-ms-input-placeholder {  
   font-style: italic; 
}
        .auto-style11 {
            width: 100%;
        }
        .auto-style12 {
            width: 224px;
        }
    </style>
</head>
<body style="height: 377px">
    <form id="form1" runat="server">
        <div>
            <h1>PATIENT SIGNUP</h1>
            <asp:ScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ScriptManager>


        </div>


        <table class="auto-style1">
            <tr>
                <td class="auto-style2" style="width: 70px">
                    <asp:Label ID="Label1" runat="server" Style="font-weight: 700" Text="First Name"></asp:Label>

                </td>
                <td style="width: 539px">
                    <asp:TextBox ID="TextBox1" runat="server" placeholder="Your firstname" ForeColor="Black"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" BackColor="White" BorderColor="Red" ControlToValidate="TextBox1" ErrorMessage="*ONLY ALPHABETS ALLOWED" ForeColor="Red" Style="font-weight: 700" ValidationExpression="^[a-zA-Z\s]+$"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" style="width: 70px">
                    <asp:Label ID="Label2" runat="server" Style="font-weight: 700" Text="Last Name"></asp:Label>
                </td>
                <td style="width: 539px">
                    <asp:TextBox ID="TextBox2" runat="server" placeholder="Your lastname" ForeColor="Black"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="*ONLY ALPHABETS ALLOWED" ForeColor="Red" Style="font-weight: 700" ValidationExpression="^[a-zA-Z\s]+$"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" style="width: 70px">
                    <asp:Label ID="Label3" runat="server" Style="font-weight: 700" Text="Date Of Birth"></asp:Label>
                </td>
                <td style="font-weight: 700; width: 539px;">
                    <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
                    <acp:CalendarExtender ID="TextBox11_CalendarExtender" runat="server" Enabled="True" TargetControlID="TextBox11">
                    </acp:CalendarExtender>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">
                    <asp:Label ID="Label4" runat="server" Style="font-weight: 700" Text="Age"></asp:Label>
                </td>
                <td class="auto-style10">
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" ControlToValidate="TextBox4" ErrorMessage="ENTER A VALID RANGE" ForeColor="Red" Style="font-weight: 700" ValidationExpression="^(\d?[0-9]|[0-9]0)$"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style5" style="width: 70px; height: 27px;">
                    <asp:Label ID="Label5" runat="server" Style="font-weight: 700" Text="Blood Group"></asp:Label>
                </td>
                <td class="auto-style6" style="width: 539px; height: 27px;">
                    <asp:DropDownList ID="DropDownList2" runat="server" Width="124px">
                        <asp:ListItem>SELECT</asp:ListItem>
                        <asp:ListItem>B+</asp:ListItem>
                        <asp:ListItem>AB+</asp:ListItem>
                        <asp:ListItem>O+</asp:ListItem>
                        <asp:ListItem>A-</asp:ListItem>
                        <asp:ListItem>B-</asp:ListItem>
                        <asp:ListItem>AB-</asp:ListItem>
                        <asp:ListItem>O-</asp:ListItem>
                        <asp:ListItem>A+</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" style="width: 70px">
                    <asp:Label ID="Label6" runat="server" Style="font-weight: 700" Text="Phone no."></asp:Label>
                </td>
                <td style="width: 539px">
                    <asp:TextBox ID="TextBox6" runat="server" placeholder="eg. 9876543210" ForeColor="Black" ValidateRequestMode="Enabled" MaxLength="10"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="TextBox6" ErrorMessage="*ENTER A VALID PHONE NUMBER" ForeColor="Red" Style="font-weight: 700" ValidationExpression="^[7-9]\d{9}$" ValidationGroup="false"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style7" style="width: 70px">
                    <asp:Label ID="Label7" runat="server" Style="font-weight: 700" Text="Address"></asp:Label>
                </td>
                <td class="auto-style8" style="width: 539px">
                    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" style="width: 70px">
                    <asp:Label ID="Label8" runat="server" Style="font-weight: 700" Text="Email id"></asp:Label>
                </td>
                <td style="width: 539px">
                    <asp:TextBox ID="TextBox8" runat="server" placeholder="eg. abc@gmail.com" ForeColor="Black"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="TextBox8" ErrorMessage="INVALID" ForeColor="Red" Style="font-weight: 700" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>

            <tr>
                <td style="width: 142px">
                    <asp:Label ID="Label12" runat="server" Style="font-weight: 700" Text="Gender"></asp:Label>
                </td>
                <td style="width: 539px">
                    <asp:DropDownList ID="DropDownList4" runat="server">
                        <asp:ListItem>Choose</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                        <asp:ListItem>Male</asp:ListItem>
                        <asp:ListItem>Others</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td style="width: 142px; height: 26px;">
                    <asp:Label ID="Label11" runat="server" Style="font-weight: 700" Text="Department"></asp:Label>
                </td>
                <td style="height: 26px; width: 539px;">
                    <asp:DropDownList ID="Ddl3" runat="server" AutoPostBack="True" OnSelectedIndexChanged="Ddl3_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
            </tr>


            <tr>
                <td class="auto-style3" style="width: 70px">
                    <asp:Label ID="Label15" runat="server" Style="font-weight: 700" Text="Doctor"></asp:Label>
                </td>
                <td class="auto-style4" style="width: 539px">
                    <asp:DropDownList ID="DropDownList5" runat="server" AppendDataBoundItems="false">
                        <asp:ListItem Value="0">--Select--</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
        </table>
        <table class="auto-style11">
            <tr>
                <td class="auto-style12">
                    <asp:Label ID="Label16" runat="server" style="font-weight: 700" Text="Pincode"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox14" runat="server" MaxLength="6"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator8" runat="server" ControlToValidate="TextBox14" ErrorMessage="*INVALID PINCODE" ForeColor="Red" style="font-weight: 700" ValidationExpression="^[0-9]{6}(-[0-9]{4})?$"></asp:RegularExpressionValidator>
                </td>
            </tr>
        </table>
        <br />
        <br />
        <br />
        <asp:Label ID="Label9" runat="server" Visible="False" Style="font-weight: 700">UID</asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox12" runat="server" Visible="False" Width="154px" Enabled="False"></asp:TextBox>
        <p>
            &nbsp;<asp:Label ID="Label10" runat="server" Style="font-weight: 700" Text="USERNAME" Visible="False"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox13" runat="server" Visible="False" Enabled="False"></asp:TextBox>
        </p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            
        </p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="SIGN UP" Style="font-weight: 700; height: 26px;" ForeColor="#660066" OnClick="Button1_Click" />

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <asp:Button ID="Button2" runat="server" ForeColor="#6600FF" OnClick="Button2_Click" Style="font-weight: 700" Text="LOGIN" Visible="False" />
        </p>
    </form>
</body>
</html>
