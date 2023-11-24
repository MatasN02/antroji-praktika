namespace FormUI
{
    partial class adminPanel
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
            this.EnterStudGrupes = new System.Windows.Forms.Button();
            this.EnterDestDalykai = new System.Windows.Forms.Button();
            this.EnterDestytojai = new System.Windows.Forms.Button();
            this.EnterStudentai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EnterStudGrupes
            // 
            this.EnterStudGrupes.Location = new System.Drawing.Point(28, 25);
            this.EnterStudGrupes.Name = "EnterStudGrupes";
            this.EnterStudGrupes.Size = new System.Drawing.Size(166, 32);
            this.EnterStudGrupes.TabIndex = 0;
            this.EnterStudGrupes.Text = "Studentų grupės";
            this.EnterStudGrupes.UseVisualStyleBackColor = true;
            this.EnterStudGrupes.Click += new System.EventHandler(this.EnterStudGrupes_Click);
            // 
            // EnterDestDalykai
            // 
            this.EnterDestDalykai.Location = new System.Drawing.Point(216, 25);
            this.EnterDestDalykai.Name = "EnterDestDalykai";
            this.EnterDestDalykai.Size = new System.Drawing.Size(166, 32);
            this.EnterDestDalykai.TabIndex = 1;
            this.EnterDestDalykai.Text = "Dėstomi dalykai";
            this.EnterDestDalykai.UseVisualStyleBackColor = true;
            // 
            // EnterDestytojai
            // 
            this.EnterDestytojai.Location = new System.Drawing.Point(407, 25);
            this.EnterDestytojai.Name = "EnterDestytojai";
            this.EnterDestytojai.Size = new System.Drawing.Size(166, 32);
            this.EnterDestytojai.TabIndex = 2;
            this.EnterDestytojai.Text = "Dėstytojai";
            this.EnterDestytojai.UseVisualStyleBackColor = true;
            // 
            // EnterStudentai
            // 
            this.EnterStudentai.Location = new System.Drawing.Point(596, 25);
            this.EnterStudentai.Name = "EnterStudentai";
            this.EnterStudentai.Size = new System.Drawing.Size(166, 32);
            this.EnterStudentai.TabIndex = 3;
            this.EnterStudentai.Text = "Studentai";
            this.EnterStudentai.UseVisualStyleBackColor = true;
            this.EnterStudentai.Click += new System.EventHandler(this.EnterStudentai_Click);
            // 
            // adminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 327);
            this.Controls.Add(this.EnterStudentai);
            this.Controls.Add(this.EnterDestytojai);
            this.Controls.Add(this.EnterDestDalykai);
            this.Controls.Add(this.EnterStudGrupes);
            this.Name = "adminPanel";
            this.Text = "adminPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private Button EnterStudGrupes;
        private Button EnterDestDalykai;
        private Button EnterDestytojai;
        private Button EnterStudentai;
    }
}
