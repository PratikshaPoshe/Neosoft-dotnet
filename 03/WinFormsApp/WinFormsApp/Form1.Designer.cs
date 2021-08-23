
namespace WinFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Num1 = new System.Windows.Forms.Label();
            this.tb_Num1 = new System.Windows.Forms.TextBox();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.lbl_result = new System.Windows.Forms.Label();
            this.lbl_num2 = new System.Windows.Forms.Label();
            this.tb_num2 = new System.Windows.Forms.TextBox();
            this.btn_Substract = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Num1
            // 
            this.lbl_Num1.AutoSize = true;
            this.lbl_Num1.Location = new System.Drawing.Point(88, 86);
            this.lbl_Num1.Name = "lbl_Num1";
            this.lbl_Num1.Size = new System.Drawing.Size(154, 25);
            this.lbl_Num1.TabIndex = 0;
            this.lbl_Num1.Text = "Enter first number";
            // 
            // tb_Num1
            // 
            this.tb_Num1.Location = new System.Drawing.Point(265, 86);
            this.tb_Num1.Name = "tb_Num1";
            this.tb_Num1.Size = new System.Drawing.Size(229, 31);
            this.tb_Num1.TabIndex = 1;
            // 
            // Btn_Add
            // 
            this.Btn_Add.Location = new System.Drawing.Point(574, 77);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(112, 34);
            this.Btn_Add.TabIndex = 2;
            this.Btn_Add.Text = "Add";
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.btn_Click);
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(59, 370);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(234, 25);
            this.lbl_result.TabIndex = 3;
            this.lbl_result.Text = "Result will be displayed here";
            // 
            // lbl_num2
            // 
            this.lbl_num2.AutoSize = true;
            this.lbl_num2.Location = new System.Drawing.Point(59, 152);
            this.lbl_num2.Name = "lbl_num2";
            this.lbl_num2.Size = new System.Drawing.Size(183, 25);
            this.lbl_num2.TabIndex = 4;
            this.lbl_num2.Text = "Enter Second number";
            // 
            // tb_num2
            // 
            this.tb_num2.Location = new System.Drawing.Point(265, 152);
            this.tb_num2.Name = "tb_num2";
            this.tb_num2.Size = new System.Drawing.Size(229, 31);
            this.tb_num2.TabIndex = 5;
            // 
            // btn_Substract
            // 
            this.btn_Substract.Location = new System.Drawing.Point(572, 149);
            this.btn_Substract.Name = "btn_Substract";
            this.btn_Substract.Size = new System.Drawing.Size(112, 34);
            this.btn_Substract.TabIndex = 6;
            this.btn_Substract.Text = "Substract";
            this.btn_Substract.UseVisualStyleBackColor = true;
            this.btn_Substract.Click += new System.EventHandler(this.btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 468);
            this.Controls.Add(this.btn_Substract);
            this.Controls.Add(this.tb_num2);
            this.Controls.Add(this.lbl_num2);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.tb_Num1);
            this.Controls.Add(this.lbl_Num1);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Num1;
        private System.Windows.Forms.TextBox tb_Num1;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Label lbl_num2;
        private System.Windows.Forms.TextBox tb_num2;
        private System.Windows.Forms.Button btn_Substract;
    }
}

