namespace CircusTreinTry
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lbCarnivore = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.Label();
            this.cbCarnivore = new System.Windows.Forms.ComboBox();
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbAmount = new System.Windows.Forms.Label();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(298, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 0;
            // 
            // lbCarnivore
            // 
            this.lbCarnivore.AutoSize = true;
            this.lbCarnivore.Location = new System.Drawing.Point(50, 77);
            this.lbCarnivore.Name = "lbCarnivore";
            this.lbCarnivore.Size = new System.Drawing.Size(52, 13);
            this.lbCarnivore.TabIndex = 1;
            this.lbCarnivore.Text = "Carnivore";
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Location = new System.Drawing.Point(50, 107);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(27, 13);
            this.lbSize.TabIndex = 2;
            this.lbSize.Text = "Size";
            // 
            // cbCarnivore
            // 
            this.cbCarnivore.FormattingEnabled = true;
            this.cbCarnivore.Items.AddRange(new object[] {
            "true",
            "false"});
            this.cbCarnivore.Location = new System.Drawing.Point(130, 74);
            this.cbCarnivore.Name = "cbCarnivore";
            this.cbCarnivore.Size = new System.Drawing.Size(121, 21);
            this.cbCarnivore.TabIndex = 3;
            // 
            // cbSize
            // 
            this.cbSize.FormattingEnabled = true;
            this.cbSize.Items.AddRange(new object[] {
            "small",
            "medium",
            "large"});
            this.cbSize.Location = new System.Drawing.Point(130, 104);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(121, 21);
            this.cbSize.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(132, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.Location = new System.Drawing.Point(50, 50);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(43, 13);
            this.lbAmount.TabIndex = 6;
            this.lbAmount.Text = "Amount";
            // 
            // nudAmount
            // 
            this.nudAmount.Location = new System.Drawing.Point(132, 48);
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(75, 20);
            this.nudAmount.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nudAmount);
            this.Controls.Add(this.lbAmount);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbSize);
            this.Controls.Add(this.cbCarnivore);
            this.Controls.Add(this.lbSize);
            this.Controls.Add(this.lbCarnivore);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lbCarnivore;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.ComboBox cbCarnivore;
        private System.Windows.Forms.ComboBox cbSize;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.NumericUpDown nudAmount;
    }
}

