using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {

        if (TextBox1.Text.ToString() == "")
        {
            TextBox1.Text = Calendar1.SelectedDate.ToString();
        }
        else {
            TextBox2.Text = Calendar1.SelectedDate.ToString();
        }
     
    }



    protected void Button1_Click(object sender, EventArgs e)
    {
        DateTime D1 = Convert.ToDateTime(TextBox1.Text);
        DateTime D2 = Convert.ToDateTime(TextBox2.Text);
        TimeSpan tspan = D2.Subtract(D1);
        lbl1.Text = ((int)tspan.TotalDays).ToString();
    }
}