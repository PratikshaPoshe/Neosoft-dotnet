using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class Cat : System.Web.UI.Page
    {        
        protected void Page_Load(object sender, EventArgs e)
        {
            dd_CatType.DataSource = Enum.GetNames(typeof(CatType));
            dd_CatType.DataBind();
            dd_FurType.DataSource = Enum.GetNames(typeof(FurType));
            dd_FurType.DataBind();
            //Load_dd_CatType();
            //Load_dd_FurType();
        }

        private void Load_dd_CatType()
        {
            foreach (var ct in Enum.GetValues(typeof(CatType)))
            {
                ListItem item = new ListItem(Enum.GetName(typeof(CatType), ct), ct.ToString());
                dd_CatType.Items.Add(item);
            }
        }
        private void Load_dd_FurType()
        {
            foreach (var ct in Enum.GetValues(typeof(FurType)))
            {
                ListItem item = new ListItem(Enum.GetName(typeof(FurType), ct), ct.ToString());
                dd_FurType.Items.Add(item);
            }
        }
        protected void btn_Add_Click(object sender, EventArgs e)
        {
            lbl_Display.Text = $"Name - {tb_Name.Text} <br>Date of Birth - {tb_Dob.Text}";
            if (rb_Male.Checked)
            {
                lbl_Display.Text += $"<br>Gender - {rb_Male.Text}";
            }
            else
            {
                lbl_Display.Text += $"<br>Gender - {rb_Female.Text}";
            }
            lbl_Display.Text += $"<br>Cat Type - {dd_CatType.SelectedValue} <br>Fur Type - {dd_FurType.SelectedValue}";

        }
        
    }
}