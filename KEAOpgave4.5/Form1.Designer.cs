namespace KEAOpgave4._5
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxX = new System.Windows.Forms.ListBox();
            this.listBoxSquareRoot = new System.Windows.Forms.ListBox();
            this.listBoxX2 = new System.Windows.Forms.ListBox();
            this.listBoxX3 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(477, 40);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(129, 49);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(42, 92);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(100, 31);
            this.textBoxX.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Type in the maximum value of X:";
            // 
            // listBoxX
            // 
            this.listBoxX.FormattingEnabled = true;
            this.listBoxX.ItemHeight = 25;
            this.listBoxX.Location = new System.Drawing.Point(37, 152);
            this.listBoxX.Name = "listBoxX";
            this.listBoxX.Size = new System.Drawing.Size(220, 604);
            this.listBoxX.TabIndex = 3;
            // 
            // listBoxSquareRoot
            // 
            this.listBoxSquareRoot.FormattingEnabled = true;
            this.listBoxSquareRoot.ItemHeight = 25;
            this.listBoxSquareRoot.Location = new System.Drawing.Point(263, 152);
            this.listBoxSquareRoot.Name = "listBoxSquareRoot";
            this.listBoxSquareRoot.Size = new System.Drawing.Size(220, 604);
            this.listBoxSquareRoot.TabIndex = 4;
            // 
            // listBoxX2
            // 
            this.listBoxX2.FormattingEnabled = true;
            this.listBoxX2.ItemHeight = 25;
            this.listBoxX2.Location = new System.Drawing.Point(489, 152);
            this.listBoxX2.Name = "listBoxX2";
            this.listBoxX2.Size = new System.Drawing.Size(220, 604);
            this.listBoxX2.TabIndex = 5;
            // 
            // listBoxX3
            // 
            this.listBoxX3.FormattingEnabled = true;
            this.listBoxX3.ItemHeight = 25;
            this.listBoxX3.Location = new System.Drawing.Point(715, 152);
            this.listBoxX3.Name = "listBoxX3";
            this.listBoxX3.Size = new System.Drawing.Size(220, 604);
            this.listBoxX3.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 759);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 759);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Square root of X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(742, 759);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "X to the pow of 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(512, 759);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "X to the pow of 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 868);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxX3);
            this.Controls.Add(this.listBoxX2);
            this.Controls.Add(this.listBoxSquareRoot);
            this.Controls.Add(this.listBoxX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.buttonStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxX;
        private System.Windows.Forms.ListBox listBoxSquareRoot;
        private System.Windows.Forms.ListBox listBoxX2;
        private System.Windows.Forms.ListBox listBoxX3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

