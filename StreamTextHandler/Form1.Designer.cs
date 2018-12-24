namespace StreamTextHandler
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Update = new System.Windows.Forms.Button();
            this.textBox_style = new System.Windows.Forms.TextBox();
            this.textBox_W = new System.Windows.Forms.NumericUpDown();
            this.textBox_L = new System.Windows.Forms.NumericUpDown();
            this.textBox_D = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_W)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_L)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_D)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wins";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Losses";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Draws";
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(110, 137);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(75, 23);
            this.button_Update.TabIndex = 6;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // textBox_style
            // 
            this.textBox_style.Location = new System.Drawing.Point(12, 114);
            this.textBox_style.Name = "textBox_style";
            this.textBox_style.Size = new System.Drawing.Size(173, 20);
            this.textBox_style.TabIndex = 7;
            this.textBox_style.Text = "{W} - {L} - {D}";
            // 
            // textBox_W
            // 
            this.textBox_W.Location = new System.Drawing.Point(65, 28);
            this.textBox_W.Name = "textBox_W";
            this.textBox_W.Size = new System.Drawing.Size(120, 20);
            this.textBox_W.TabIndex = 14;
            // 
            // textBox_L
            // 
            this.textBox_L.Location = new System.Drawing.Point(65, 59);
            this.textBox_L.Name = "textBox_L";
            this.textBox_L.Size = new System.Drawing.Size(120, 20);
            this.textBox_L.TabIndex = 15;
            // 
            // textBox_D
            // 
            this.textBox_D.Location = new System.Drawing.Point(65, 88);
            this.textBox_D.Name = "textBox_D";
            this.textBox_D.Size = new System.Drawing.Size(120, 20);
            this.textBox_D.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 172);
            this.Controls.Add(this.textBox_D);
            this.Controls.Add(this.textBox_L);
            this.Controls.Add(this.textBox_W);
            this.Controls.Add(this.textBox_style);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "KWLDT";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textBox_W)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_L)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox_D)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.TextBox textBox_style;
        private System.Windows.Forms.NumericUpDown textBox_W;
        private System.Windows.Forms.NumericUpDown textBox_L;
        private System.Windows.Forms.NumericUpDown textBox_D;
    }
}

