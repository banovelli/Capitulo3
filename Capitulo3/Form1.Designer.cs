namespace Capitulo3
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.joesCash = new System.Windows.Forms.Label();
            this.bobsCash = new System.Windows.Forms.Label();
            this.bankCash = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "De $10 para Joe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(149, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 54);
            this.button2.TabIndex = 1;
            this.button2.Text = "Receba $5 de Bob";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // joesCash
            // 
            this.joesCash.AutoSize = true;
            this.joesCash.Location = new System.Drawing.Point(45, 13);
            this.joesCash.Name = "joesCash";
            this.joesCash.Size = new System.Drawing.Size(35, 13);
            this.joesCash.TabIndex = 2;
            this.joesCash.Text = "label1";
            // 
            // bobsCash
            // 
            this.bobsCash.AutoSize = true;
            this.bobsCash.Location = new System.Drawing.Point(45, 39);
            this.bobsCash.Name = "bobsCash";
            this.bobsCash.Size = new System.Drawing.Size(35, 13);
            this.bobsCash.TabIndex = 3;
            this.bobsCash.Text = "label2";
            // 
            // bankCash
            // 
            this.bankCash.AutoSize = true;
            this.bankCash.Location = new System.Drawing.Point(48, 65);
            this.bankCash.Name = "bankCash";
            this.bankCash.Size = new System.Drawing.Size(35, 13);
            this.bankCash.TabIndex = 4;
            this.bankCash.Text = "label3";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(48, 183);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 48);
            this.button3.TabIndex = 5;
            this.button3.Text = "Joe dá $10 para Bob";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(149, 183);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(68, 48);
            this.button4.TabIndex = 6;
            this.button4.Text = "Bob dá $ 5  para Joe";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 238);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bankCash);
            this.Controls.Add(this.bobsCash);
            this.Controls.Add(this.joesCash);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Diversão com Joe e Bob";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label joesCash;
        private System.Windows.Forms.Label bobsCash;
        private System.Windows.Forms.Label bankCash;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

