namespace Tic_Tac_Toe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.A1 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.NGButton = new System.Windows.Forms.Button();
            this.RButton = new System.Windows.Forms.Button();
            this.EButton = new System.Windows.Forms.Button();
            this.XWin = new System.Windows.Forms.Label();
            this.Draw = new System.Windows.Forms.Label();
            this.OWin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // A1
            // 
            this.A1.Location = new System.Drawing.Point(12, 12);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(100, 100);
            this.A1.TabIndex = 0;
            this.A1.UseVisualStyleBackColor = true;
            this.A1.Click += new System.EventHandler(this.buttonClick);
            // 
            // C1
            // 
            this.C1.Location = new System.Drawing.Point(224, 12);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(100, 100);
            this.C1.TabIndex = 1;
            this.C1.UseVisualStyleBackColor = true;
            this.C1.Click += new System.EventHandler(this.buttonClick);
            // 
            // B2
            // 
            this.B2.Location = new System.Drawing.Point(118, 118);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(100, 100);
            this.B2.TabIndex = 2;
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.buttonClick);
            // 
            // B1
            // 
            this.B1.Location = new System.Drawing.Point(118, 12);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(100, 100);
            this.B1.TabIndex = 3;
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.buttonClick);
            // 
            // A3
            // 
            this.A3.Location = new System.Drawing.Point(12, 224);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(100, 100);
            this.A3.TabIndex = 4;
            this.A3.UseVisualStyleBackColor = true;
            this.A3.Click += new System.EventHandler(this.buttonClick);
            // 
            // A2
            // 
            this.A2.Location = new System.Drawing.Point(12, 118);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(100, 100);
            this.A2.TabIndex = 5;
            this.A2.UseVisualStyleBackColor = true;
            this.A2.Click += new System.EventHandler(this.buttonClick);
            // 
            // B3
            // 
            this.B3.Location = new System.Drawing.Point(118, 224);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(100, 100);
            this.B3.TabIndex = 6;
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.buttonClick);
            // 
            // C2
            // 
            this.C2.Location = new System.Drawing.Point(224, 118);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(100, 100);
            this.C2.TabIndex = 7;
            this.C2.UseVisualStyleBackColor = true;
            this.C2.Click += new System.EventHandler(this.buttonClick);
            // 
            // C3
            // 
            this.C3.Location = new System.Drawing.Point(224, 224);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(100, 100);
            this.C3.TabIndex = 8;
            this.C3.UseVisualStyleBackColor = true;
            this.C3.Click += new System.EventHandler(this.buttonClick);
            // 
            // NGButton
            // 
            this.NGButton.Location = new System.Drawing.Point(12, 355);
            this.NGButton.Name = "NGButton";
            this.NGButton.Size = new System.Drawing.Size(100, 34);
            this.NGButton.TabIndex = 9;
            this.NGButton.Text = "New Game";
            this.NGButton.UseVisualStyleBackColor = true;
            this.NGButton.Click += new System.EventHandler(this.NGButton_Click);
            // 
            // RButton
            // 
            this.RButton.Location = new System.Drawing.Point(118, 355);
            this.RButton.Name = "RButton";
            this.RButton.Size = new System.Drawing.Size(100, 34);
            this.RButton.TabIndex = 10;
            this.RButton.Text = "Restart";
            this.RButton.UseVisualStyleBackColor = true;
            this.RButton.Click += new System.EventHandler(this.RButton_Click);
            // 
            // EButton
            // 
            this.EButton.Location = new System.Drawing.Point(347, 355);
            this.EButton.Name = "EButton";
            this.EButton.Size = new System.Drawing.Size(100, 34);
            this.EButton.TabIndex = 11;
            this.EButton.Text = "Exit";
            this.EButton.UseVisualStyleBackColor = true;
            this.EButton.Click += new System.EventHandler(this.EButton_Click);
            // 
            // XWin
            // 
            this.XWin.Location = new System.Drawing.Point(344, 35);
            this.XWin.Name = "XWin";
            this.XWin.Size = new System.Drawing.Size(118, 58);
            this.XWin.TabIndex = 12;
            this.XWin.Text = "label1";
            // 
            // Draw
            // 
            this.Draw.Location = new System.Drawing.Point(344, 252);
            this.Draw.Name = "Draw";
            this.Draw.Size = new System.Drawing.Size(137, 58);
            this.Draw.TabIndex = 13;
            this.Draw.Text = "label1";
            // 
            // OWin
            // 
            this.OWin.Location = new System.Drawing.Point(344, 146);
            this.OWin.Name = "OWin";
            this.OWin.Size = new System.Drawing.Size(137, 58);
            this.OWin.TabIndex = 14;
            this.OWin.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 401);
            this.Controls.Add(this.OWin);
            this.Controls.Add(this.Draw);
            this.Controls.Add(this.XWin);
            this.Controls.Add(this.EButton);
            this.Controls.Add(this.RButton);
            this.Controls.Add(this.NGButton);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.A1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.Button NGButton;
        private System.Windows.Forms.Button RButton;
        private System.Windows.Forms.Button EButton;
        private System.Windows.Forms.Label XWin;
        private System.Windows.Forms.Label Draw;
        private System.Windows.Forms.Label OWin;
    }
}

