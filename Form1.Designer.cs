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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBoxOperator = new ComboBox();
            buttonCalculate = new Button();
            labelResult = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(30, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(200, 30);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 2;
            // 
            // comboBoxOperator
            // 
            comboBoxOperator.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOperator.Location = new Point(140, 30);
            comboBoxOperator.Name = "comboBoxOperator";
            comboBoxOperator.Size = new Size(50, 23);
            comboBoxOperator.TabIndex = 1;
            // 
            // buttonCalculate
            // 
            buttonCalculate.BackColor = Color.Red;
            buttonCalculate.Location = new Point(310, 30);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(75, 23);
            buttonCalculate.TabIndex = 3;
            buttonCalculate.Text = "Kalkulo";
            buttonCalculate.UseVisualStyleBackColor = false;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // labelResult
            // 
            labelResult.Location = new Point(30, 70);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(355, 23);
            labelResult.TabIndex = 4;
            labelResult.Text = "Rezultati:";
            // 
            // Form1
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(420, 336);
            Controls.Add(textBox1);
            Controls.Add(comboBoxOperator);
            Controls.Add(textBox2);
            Controls.Add(buttonCalculate);
            Controls.Add(labelResult);
            HelpButton = true;
            MaximumSize = new Size(811, 411);
            MinimumSize = new Size(184, 92);
            Name = "Form1";
            Text = "GUI Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
