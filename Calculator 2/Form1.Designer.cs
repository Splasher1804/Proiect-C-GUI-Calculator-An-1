namespace Calculator_2
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.result = new System.Windows.Forms.Label();
            this.Del = new System.Windows.Forms.Button();
            this.Impartit = new System.Windows.Forms.Button();
            this.butt1 = new System.Windows.Forms.Button();
            this.butt4 = new System.Windows.Forms.Button();
            this.butt2 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.butt5 = new System.Windows.Forms.Button();
            this.butt3 = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Ori = new System.Windows.Forms.Button();
            this.butt6 = new System.Windows.Forms.Button();
            this.butt7 = new System.Windows.Forms.Button();
            this.butt8 = new System.Windows.Forms.Button();
            this.butt9 = new System.Windows.Forms.Button();
            this.Equal = new System.Windows.Forms.Button();
            this.butt0 = new System.Windows.Forms.Button();
            this.Point = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.Live = new System.Windows.Forms.Label();
            this.Clear_Label = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Radical = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.SystemColors.Window;
            this.result.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.result.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.result.Location = new System.Drawing.Point(15, 20);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(443, 53);
            this.result.TabIndex = 0;
            this.result.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // Del
            // 
            this.Del.BackColor = System.Drawing.Color.LightGreen;
            this.Del.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Del.ForeColor = System.Drawing.Color.Fuchsia;
            this.Del.Location = new System.Drawing.Point(15, 89);
            this.Del.Name = "Del";
            this.Del.Size = new System.Drawing.Size(218, 64);
            this.Del.TabIndex = 1;
            this.Del.Text = "CE";
            this.Del.UseVisualStyleBackColor = false;
            this.Del.Click += new System.EventHandler(this.Sterge);
            // 
            // Impartit
            // 
            this.Impartit.BackColor = System.Drawing.Color.LightGreen;
            this.Impartit.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Impartit.ForeColor = System.Drawing.Color.Fuchsia;
            this.Impartit.Location = new System.Drawing.Point(351, 167);
            this.Impartit.Name = "Impartit";
            this.Impartit.Size = new System.Drawing.Size(106, 64);
            this.Impartit.TabIndex = 1;
            this.Impartit.Text = "/";
            this.Impartit.UseVisualStyleBackColor = false;
            this.Impartit.Click += new System.EventHandler(this.Operator_Click);
            // 
            // butt1
            // 
            this.butt1.BackColor = System.Drawing.Color.LightGreen;
            this.butt1.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.butt1.ForeColor = System.Drawing.Color.Fuchsia;
            this.butt1.Location = new System.Drawing.Point(15, 167);
            this.butt1.Name = "butt1";
            this.butt1.Size = new System.Drawing.Size(106, 64);
            this.butt1.TabIndex = 1;
            this.butt1.Text = "1";
            this.butt1.UseVisualStyleBackColor = false;
            this.butt1.Click += new System.EventHandler(this.Butt1);
            // 
            // butt4
            // 
            this.butt4.BackColor = System.Drawing.Color.LightGreen;
            this.butt4.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.butt4.ForeColor = System.Drawing.Color.Fuchsia;
            this.butt4.Location = new System.Drawing.Point(15, 238);
            this.butt4.Name = "butt4";
            this.butt4.Size = new System.Drawing.Size(106, 64);
            this.butt4.TabIndex = 1;
            this.butt4.Text = "4";
            this.butt4.UseVisualStyleBackColor = false;
            this.butt4.Click += new System.EventHandler(this.Butt1);
            // 
            // butt2
            // 
            this.butt2.BackColor = System.Drawing.Color.LightGreen;
            this.butt2.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.butt2.ForeColor = System.Drawing.Color.Fuchsia;
            this.butt2.Location = new System.Drawing.Point(126, 167);
            this.butt2.Name = "butt2";
            this.butt2.Size = new System.Drawing.Size(106, 64);
            this.butt2.TabIndex = 1;
            this.butt2.Text = "2";
            this.butt2.UseVisualStyleBackColor = false;
            this.butt2.Click += new System.EventHandler(this.Butt1);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button9.Location = new System.Drawing.Point(-4, 161);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(94, 65);
            this.button9.TabIndex = 1;
            this.button9.Text = "button5";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button10.Location = new System.Drawing.Point(-4, 232);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(94, 65);
            this.button10.TabIndex = 1;
            this.button10.Text = "button6";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button11.Location = new System.Drawing.Point(96, 161);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(94, 65);
            this.button11.TabIndex = 1;
            this.button11.Text = "button7";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button12.Location = new System.Drawing.Point(146, 193);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(94, 65);
            this.button12.TabIndex = 1;
            this.button12.Text = "button8";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // butt5
            // 
            this.butt5.BackColor = System.Drawing.Color.LightGreen;
            this.butt5.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.butt5.ForeColor = System.Drawing.Color.Fuchsia;
            this.butt5.Location = new System.Drawing.Point(126, 238);
            this.butt5.Name = "butt5";
            this.butt5.Size = new System.Drawing.Size(106, 64);
            this.butt5.TabIndex = 1;
            this.butt5.Text = "5";
            this.butt5.UseVisualStyleBackColor = false;
            this.butt5.Click += new System.EventHandler(this.Butt1);
            // 
            // butt3
            // 
            this.butt3.BackColor = System.Drawing.Color.LightGreen;
            this.butt3.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.butt3.ForeColor = System.Drawing.Color.Fuchsia;
            this.butt3.Location = new System.Drawing.Point(237, 167);
            this.butt3.Name = "butt3";
            this.butt3.Size = new System.Drawing.Size(106, 64);
            this.butt3.TabIndex = 1;
            this.butt3.Text = "3";
            this.butt3.UseVisualStyleBackColor = false;
            this.butt3.Click += new System.EventHandler(this.Butt1);
            // 
            // Minus
            // 
            this.Minus.BackColor = System.Drawing.Color.LightGreen;
            this.Minus.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Minus.ForeColor = System.Drawing.Color.Fuchsia;
            this.Minus.Location = new System.Drawing.Point(351, 309);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(106, 64);
            this.Minus.TabIndex = 1;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = false;
            this.Minus.Click += new System.EventHandler(this.Operator_Click);
            // 
            // Ori
            // 
            this.Ori.BackColor = System.Drawing.Color.LightGreen;
            this.Ori.Font = new System.Drawing.Font("Showcard Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Ori.ForeColor = System.Drawing.Color.Fuchsia;
            this.Ori.Location = new System.Drawing.Point(351, 238);
            this.Ori.Name = "Ori";
            this.Ori.Size = new System.Drawing.Size(106, 64);
            this.Ori.TabIndex = 1;
            this.Ori.Text = "x";
            this.Ori.UseVisualStyleBackColor = false;
            this.Ori.Click += new System.EventHandler(this.Operator_Click);
            // 
            // butt6
            // 
            this.butt6.BackColor = System.Drawing.Color.LightGreen;
            this.butt6.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.butt6.ForeColor = System.Drawing.Color.Fuchsia;
            this.butt6.Location = new System.Drawing.Point(237, 238);
            this.butt6.Name = "butt6";
            this.butt6.Size = new System.Drawing.Size(106, 64);
            this.butt6.TabIndex = 1;
            this.butt6.Text = "6";
            this.butt6.UseVisualStyleBackColor = false;
            this.butt6.Click += new System.EventHandler(this.Butt1);
            // 
            // butt7
            // 
            this.butt7.BackColor = System.Drawing.Color.LightGreen;
            this.butt7.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.butt7.ForeColor = System.Drawing.Color.Fuchsia;
            this.butt7.Location = new System.Drawing.Point(15, 309);
            this.butt7.Name = "butt7";
            this.butt7.Size = new System.Drawing.Size(106, 64);
            this.butt7.TabIndex = 1;
            this.butt7.Text = "7";
            this.butt7.UseVisualStyleBackColor = false;
            this.butt7.Click += new System.EventHandler(this.Butt1);
            // 
            // butt8
            // 
            this.butt8.BackColor = System.Drawing.Color.LightGreen;
            this.butt8.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.butt8.ForeColor = System.Drawing.Color.Fuchsia;
            this.butt8.Location = new System.Drawing.Point(126, 309);
            this.butt8.Name = "butt8";
            this.butt8.Size = new System.Drawing.Size(106, 64);
            this.butt8.TabIndex = 1;
            this.butt8.Text = "8";
            this.butt8.UseVisualStyleBackColor = false;
            this.butt8.Click += new System.EventHandler(this.Butt1);
            // 
            // butt9
            // 
            this.butt9.BackColor = System.Drawing.Color.LightGreen;
            this.butt9.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.butt9.ForeColor = System.Drawing.Color.Fuchsia;
            this.butt9.Location = new System.Drawing.Point(237, 309);
            this.butt9.Name = "butt9";
            this.butt9.Size = new System.Drawing.Size(106, 64);
            this.butt9.TabIndex = 1;
            this.butt9.Text = "9";
            this.butt9.UseVisualStyleBackColor = false;
            this.butt9.Click += new System.EventHandler(this.Butt1);
            // 
            // Equal
            // 
            this.Equal.BackColor = System.Drawing.Color.LightGreen;
            this.Equal.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Equal.ForeColor = System.Drawing.Color.Fuchsia;
            this.Equal.Location = new System.Drawing.Point(237, 379);
            this.Equal.Name = "Equal";
            this.Equal.Size = new System.Drawing.Size(106, 64);
            this.Equal.TabIndex = 1;
            this.Equal.Text = "=";
            this.Equal.UseVisualStyleBackColor = false;
            this.Equal.Click += new System.EventHandler(this.Egal);
            // 
            // butt0
            // 
            this.butt0.BackColor = System.Drawing.Color.LightGreen;
            this.butt0.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.butt0.ForeColor = System.Drawing.Color.Fuchsia;
            this.butt0.Location = new System.Drawing.Point(126, 380);
            this.butt0.Name = "butt0";
            this.butt0.Size = new System.Drawing.Size(106, 64);
            this.butt0.TabIndex = 1;
            this.butt0.Text = "0";
            this.butt0.UseVisualStyleBackColor = false;
            this.butt0.Click += new System.EventHandler(this.Butt1);
            // 
            // Point
            // 
            this.Point.BackColor = System.Drawing.Color.LightGreen;
            this.Point.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Point.ForeColor = System.Drawing.Color.Fuchsia;
            this.Point.Location = new System.Drawing.Point(15, 379);
            this.Point.Name = "Point";
            this.Point.Size = new System.Drawing.Size(106, 64);
            this.Point.TabIndex = 1;
            this.Point.Text = ",";
            this.Point.UseVisualStyleBackColor = false;
            this.Point.Click += new System.EventHandler(this.Butt1);
            // 
            // Plus
            // 
            this.Plus.BackColor = System.Drawing.Color.LightGreen;
            this.Plus.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Plus.ForeColor = System.Drawing.Color.Fuchsia;
            this.Plus.Location = new System.Drawing.Point(351, 380);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(106, 64);
            this.Plus.TabIndex = 1;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = false;
            this.Plus.Click += new System.EventHandler(this.Operator_Click);
            // 
            // Live
            // 
            this.Live.AutoSize = true;
            this.Live.Location = new System.Drawing.Point(15, 20);
            this.Live.Name = "Live";
            this.Live.Size = new System.Drawing.Size(0, 20);
            this.Live.TabIndex = 2;
            // 
            // Clear_Label
            // 
            this.Clear_Label.BackColor = System.Drawing.Color.LightGreen;
            this.Clear_Label.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Clear_Label.ForeColor = System.Drawing.Color.Fuchsia;
            this.Clear_Label.Location = new System.Drawing.Point(237, 89);
            this.Clear_Label.MaximumSize = new System.Drawing.Size(218, 64);
            this.Clear_Label.Name = "Clear_Label";
            this.Clear_Label.Size = new System.Drawing.Size(106, 64);
            this.Clear_Label.TabIndex = 1;
            this.Clear_Label.Text = "Clear";
            this.Clear_Label.UseVisualStyleBackColor = false;
            this.Clear_Label.Click += new System.EventHandler(this.Stergetot);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 448);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Realizat de student Miu Mihai Florian 4LF791\r\nPot fi folosite tastele de la tasta" +
    "tura: q=CE, w=Clear, s=sqrt\r\n\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Radical
            // 
            this.Radical.BackColor = System.Drawing.Color.LightGreen;
            this.Radical.Font = new System.Drawing.Font("Showcard Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Radical.ForeColor = System.Drawing.Color.Fuchsia;
            this.Radical.Location = new System.Drawing.Point(351, 89);
            this.Radical.Name = "Radical";
            this.Radical.Size = new System.Drawing.Size(106, 64);
            this.Radical.TabIndex = 1;
            this.Radical.Text = "sqrt";
            this.Radical.UseVisualStyleBackColor = false;
            this.Radical.Click += new System.EventHandler(this.Operator_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 488);
            this.Controls.Add(this.Radical);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Clear_Label);
            this.Controls.Add(this.Live);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.Point);
            this.Controls.Add(this.butt0);
            this.Controls.Add(this.Equal);
            this.Controls.Add(this.butt9);
            this.Controls.Add(this.butt8);
            this.Controls.Add(this.butt7);
            this.Controls.Add(this.butt6);
            this.Controls.Add(this.Ori);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.butt3);
            this.Controls.Add(this.butt5);
            this.Controls.Add(this.butt2);
            this.Controls.Add(this.butt4);
            this.Controls.Add(this.butt1);
            this.Controls.Add(this.Impartit);
            this.Controls.Add(this.Del);
            this.Controls.Add(this.result);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.ForestGreen;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(488, 535);
            this.Name = "Calculator";
            this.Opacity = 0.95D;
            this.Text = "Calculator ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Calculator_Keypress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button Del;
        private System.Windows.Forms.Button Impartit;
        private System.Windows.Forms.Button butt1;
        private System.Windows.Forms.Button butt4;
        private System.Windows.Forms.Button butt2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button butt5;
        private System.Windows.Forms.Button butt3;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Ori;
        private System.Windows.Forms.Button butt6;
        private System.Windows.Forms.Button butt7;
        private System.Windows.Forms.Button butt8;
        private System.Windows.Forms.Button butt9;
        private System.Windows.Forms.Button Equal;
        private System.Windows.Forms.Button butt0;
        private System.Windows.Forms.Button Point;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Label Live;
        private System.Windows.Forms.Button Clear_Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Radical;
    }
}

