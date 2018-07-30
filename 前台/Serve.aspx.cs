using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Serve : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
     protected void Imagebutton_Click3(object sender, ImageClickEventArgs e)
    {
        string date = DateTime.Now.ToString();
        DataBase.ExecSql("INSERT INTO [Qingqiu] ( [FjID],[Qingqiu],[tjsj] ) VALUES ('" + Request.Form["house-number"] + "','" + Request.Form["house-serve"] + "','" + date + "')");
        Page.ClientScript.RegisterStartupScript(this.GetType(), "info", "<script>alert('提交成功！');window.location.href='User.aspx';</script>");
    }
}