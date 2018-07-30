using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class User : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Imagebutton_Click(object sender, ImageClickEventArgs e)
    {
        //判断信息是否正确
        if (this.Request.Form["cHouse"].Trim() == "请选择")
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "info", "<script>alert('客房类型不能为空！');</script>");
            return;
        }
        if (this.txtXM.Text.Trim() == "")
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "info", "<script>alert('姓名不能为空！');</script>");
            return;
        }

        if (this.txtDH.Text.Trim() == "")
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "info", "<script>alert('电话不能为空！');</script>");
            return;
        }
        if (this.txtDC.Text.Trim() == "")
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "info", "<script>alert('入住天数不能为空！');</script>");
            return;
        }
        if (this.txtDH.Text.Trim().Length != 11)
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "info", "<script>alert('电话号码格式不正确');</script>");
            return;
        }

        //添加注册的会员信息到数据库中
       
        string date = DateTime.Now.ToString();
        DataBase.ExecSql("INSERT INTO [kehu] ( [xm],[dh] ,[rzts],[dflx],[dfsj]) VALUES ('" + txtXM.Text + "','" + txtDH.Text + "','" + txtDC.Text + "','" + Request.Form["cHouse"] + "','" + date + "')");
        Session["UserName"] = this.txtXM.Text.Trim();
        Session["UserName"] = this.txtDH.Text.Trim();

        Page.ClientScript.RegisterStartupScript(this.GetType(), "info", "<script>alert('提交成功！');window.location.href='User.aspx';</script>");

    }
    protected void Imagebutton_Click1(object sender, ImageClickEventArgs e)
    {

    }
}
    
   
