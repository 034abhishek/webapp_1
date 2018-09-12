<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="AddEditCategory.aspx.cs" Inherits="WebApp_1.Admin.AddEditCategory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div align="center">
        <h4>Add New Category</h4>
                <hr />
           </div>
    <table align="center" cellspacing="1" style="width:50%; background-color:#4cff00;">
        <tr>
            <td style="width:50%; padding-left:100px" align="left">
                Category Name
            </td>
            <td style="width:50%;" align="left">
                <asp:TextBox ID="txtCategoryName" runat="server" Width="212px"></asp:TextBox>
            </td>
        </tr>

         <tr>
            <td style="width:50%; padding-left:100px;" align="left">
                
            </td>
             <td style="width:50%;" align="left">
                 <asp:Button ID="btnSubmit" runat="server" Text="Submit" Width="100px" Height="30px" OnClick="btnsubmit_Click" />
             </td>
        </tr>

         <tr>
            <td style="width:50%;" align="left">
              
            </td>
             <td style="width:50%;" align="right">
                 
             </td>
        </tr>
        
         <tr>
            <td style="width:50%;" align="left">
                
            </td>
             <td style="width:50%;" align="right">
                 
             </td>
        </tr>
    </table>
</asp:Content>
