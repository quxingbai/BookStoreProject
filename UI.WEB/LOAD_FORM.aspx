<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LOAD_FORM.aspx.cs" Inherits="UI.WEB.LOAD_FORM" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <asp:TextBox runat="server" ID="TEXT_LOAD_EMAIL" />
                <asp:TextBox runat="server" ID="TEXT_LOAD_PASSWORD" />
                <asp:Button runat="server" ID="BT_LOAD_SUBMIT"  OnClick="BT_LOAD_SUBMIT_Click" OnClientClick="return Not_Null()" Text="登录"/>
            </div>
        </div>
    </form>
    <script>
        //判断账号密码是否为空
        function Not_Null() {
            var Email = document.getElementById("TEXT_LOAD_EMAIL").value;
            var Password = document.getElementById("TEXT_LOAD_PASSWORD").value;
            if (Email != "" && Password != "") {
                return true;
            } else {
                alert("账号或密码有空");
                return false;
            }
        }
    </script>
</body>
</html>
