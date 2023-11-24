namespace FormUI
{
    partial class StudentoPridejimoMeniu
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
            this.valVardas = new System.Windows.Forms.TextBox();
            this.valPavarde = new System.Windows.Forms.TextBox();
            this.studVardas = new System.Windows.Forms.Label();
            this.studPavarde = new System.Windows.Forms.Label();
            this.prideti = new System.Windows.Forms.Button();
            this.grupe = new System.Windows.Forms.Label();
            this.grupesPav = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupsList = new System.Windows.Forms.ListBox();
            this.refreshGroups = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // valVardas
            // 
            this.valVardas.Location = new System.Drawing.Point(191, 121);
            this.valVardas.Name = "valVardas";
            this.valVardas.Size = new System.Drawing.Size(125, 27);
            this.valVardas.TabIndex = 0;
            // 
            // valPavarde
            // 
            this.valPavarde.Location = new System.Drawing.Point(191, 195);
            this.valPavarde.Name = "valPavarde";
            this.valPavarde.Size = new System.Drawing.Size(125, 27);
            this.valPavarde.TabIndex = 1;
            // 
            // studVardas
            // 
            this.studVardas.AutoSize = true;
            this.studVardas.Location = new System.Drawing.Point(47, 124);
            this.studVardas.Name = "studVardas";
            this.studVardas.Size = new System.Drawing.Size(53, 20);
            this.studVardas.TabIndex = 2;
            this.studVardas.Text = "Vardas";
            // 
            // studPavarde
            // 
            this.studPavarde.AutoSize = true;
            this.studPavarde.Location = new System.Drawing.Point(47, 198);
            this.studPavarde.Name = "studPavarde";
            this.studPavarde.Size = new System.Drawing.Size(61, 20);
            this.studPavarde.TabIndex = 3;
            this.studPavarde.Text = "Pavardė";
            // 
            // prideti
            // 
            this.prideti.Location = new System.Drawing.Point(60, 357);
            this.prideti.Name = "prideti";
            this.prideti.Size = new System.Drawing.Size(94, 29);
            this.prideti.TabIndex = 4;
            this.prideti.Text = "Pridėti";
            this.prideti.UseVisualStyleBackColor = true;
            this.prideti.Click += new System.EventHandler(this.prideti_Click);
            // 
            // grupe
            // 
            this.grupe.AutoSize = true;
            this.grupe.Location = new System.Drawing.Point(47, 256);
            this.grupe.Name = "grupe";
            this.grupe.Size = new System.Drawing.Size(137, 20);
            this.grupe.TabIndex = 5;
            this.grupe.Text = "Grupė pavadinimas";
            // 
            // grupesPav
            // 
            this.grupesPav.Location = new System.Drawing.Point(191, 256);
            this.grupesPav.Name = "grupesPav";
            this.grupesPav.Size = new System.Drawing.Size(125, 27);
            this.grupesPav.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(507, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Visos grupes";
            // 
            // groupsList
            // 
            this.groupsList.FormattingEnabled = true;
            this.groupsList.ItemHeight = 20;
            this.groupsList.Location = new System.Drawing.Point(507, 121);
            this.groupsList.Name = "groupsList";
            this.groupsList.Size = new System.Drawing.Size(181, 264);
            this.groupsList.TabIndex = 10;
            // 
            // refreshGroups
            // 
            this.refreshGroups.Location = new System.Drawing.Point(507, 48);
            this.refreshGroups.Name = "refreshGroups";
            this.refreshGroups.Size = new System.Drawing.Size(199, 29);
            this.refreshGroups.TabIndex = 11;
            this.refreshGroups.Text = "Parodyti visas grupes";
            this.refreshGroups.UseVisualStyleBackColor = true;
            this.refreshGroups.Click += new System.EventHandler(this.refreshGroups_Click);
            // 
            // StudentoPridejimoMeniu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 443);
            this.Controls.Add(this.refreshGroups);
            this.Controls.Add(this.groupsList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grupesPav);
            this.Controls.Add(this.prideti);
            this.Controls.Add(this.grupe);
            this.Controls.Add(this.studPavarde);
            this.Controls.Add(this.studVardas);
            this.Controls.Add(this.valPavarde);
            this.Controls.Add(this.valVardas);
            this.Name = "StudentoPridejimoMeniu";
            this.Text = "StudentoPridejimoMeniu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox valVardas;
        private TextBox valPavarde;
        private Label studVardas;
        private Label studPavarde;
        private Button prideti;
        private Label grupe;
        private TextBox grupesPav;
        private Label label1;
        private ListBox groupsList;
        private Button refreshGroups;
    }
}
