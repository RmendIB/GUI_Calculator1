namespace GuiCalculator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBoxOperator;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelResult;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBoxOperator = new System.Windows.Forms.ComboBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            // 
            // comboBoxOperator
            // 
            this.comboBoxOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOperator.Location = new System.Drawing.Point(140, 30);
            this.comboBoxOperator.Name = "comboBoxOperator";
            this.comboBoxOperator.Size = new System.Drawing.Size(50, 23);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(200, 30);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(310, 30);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // labelResult
            // 
            this.labelResult.Location = new System.Drawing.Point(30, 70);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(355, 23);
            this.labelResult.Text = "Result:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(420, 120);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBoxOperator);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.labelResult);
            this.Name = "Form1";
            this.Text = "GUI Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
