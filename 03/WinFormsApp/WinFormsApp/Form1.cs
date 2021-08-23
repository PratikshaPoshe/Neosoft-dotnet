using System;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            switch ((sender as Button).Name)
            {
                case "Btn_Add":
                    lbl_result.Text = $"{tb_Num1.Text}+{tb_num2.Text} = {Convert.ToString(Int32.Parse(tb_Num1.Text) + Int32.Parse(tb_num2.Text))}";
                    break;
                case "btn_Substract":
                    lbl_result.Text = $"{tb_Num1.Text}-{tb_num2.Text} = {Convert.ToString(Int32.Parse(tb_Num1.Text) - Int32.Parse(tb_num2.Text))}";
                    break;
                default:
                    break;
            }
        }

        //private void btn_Substract_Click(object sender, EventArgs e)
        //{
        //    lbl_result.Text = $"{tb_Num1.Text}-{tb_num2.Text} = {Convert.ToString(Int32.Parse(tb_Num1.Text) - Int32.Parse(tb_num2.Text))}";
        //}
    }
}
