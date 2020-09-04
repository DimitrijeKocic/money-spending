namespace CountMoneySpending
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtb_money_spending = new System.Windows.Forms.RichTextBox();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.tb_sum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rtb_money_spending
            // 
            this.rtb_money_spending.Location = new System.Drawing.Point(13, 13);
            this.rtb_money_spending.Name = "rtb_money_spending";
            this.rtb_money_spending.Size = new System.Drawing.Size(318, 425);
            this.rtb_money_spending.TabIndex = 0;
            this.rtb_money_spending.Text = "";
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(338, 13);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(119, 23);
            this.btn_calculate.TabIndex = 1;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // tb_sum
            // 
            this.tb_sum.Enabled = false;
            this.tb_sum.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sum.Location = new System.Drawing.Point(338, 43);
            this.tb_sum.Name = "tb_sum";
            this.tb_sum.Size = new System.Drawing.Size(119, 29);
            this.tb_sum.TabIndex = 2;
            this.tb_sum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 450);
            this.Controls.Add(this.tb_sum);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.rtb_money_spending);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_money_spending;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.TextBox tb_sum;
    }
}

