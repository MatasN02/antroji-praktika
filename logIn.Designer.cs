namespace FormUI
{
    partial class logIn
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
            this.VartotojoVardas = new System.Windows.Forms.TextBox();
            this.Slaptazodis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Prisijungti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VartotojoVardas
            // 
            this.VartotojoVardas.Location = new System.Drawing.Point(158, 110);
            this.VartotojoVardas.Name = "VartotojoVardas";
            this.VartotojoVardas.Size = new System.Drawing.Size(125, 27);
            this.VartotojoVardas.TabIndex = 0;
            // 
            // Slaptazodis
            // 
            this.Slaptazodis.Location = new System.Drawing.Point(158, 226);
            this.Slaptazodis.Name = "Slaptazodis";
            this.Slaptazodis.Size = new System.Drawing.Size(125, 27);
            this.Slaptazodis.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vartotojas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Slaptazodis";
            // 
            // Prisijungti
            // 
            this.Prisijungti.Location = new System.Drawing.Point(158, 345);
            this.Prisijungti.Name = "Prisijungti";
            this.Prisijungti.Size = new System.Drawing.Size(94, 29);
            this.Prisijungti.TabIndex = 4;
            this.Prisijungti.Text = "prisijungti";
            this.Prisijungti.UseVisualStyleBackColor = true;
            this.Prisijungti.Click += new System.EventHandler(this.Prisijungti_Click);
            // 
            // logIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 468);
            this.Controls.Add(this.Prisijungti);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Slaptazodis);
            this.Controls.Add(this.VartotojoVardas);
            this.Name = "logIn";
            this.Text = "log In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox VartotojoVardas;
        private TextBox Slaptazodis;
        private Label label1;
        private Label label2;
        private Button Prisijungti;
    }
}
