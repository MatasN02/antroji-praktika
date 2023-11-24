namespace FormUI
{
    partial class studentaiMeniu
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
            this.StudentaiListBox = new System.Windows.Forms.ListBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.IterptiStudentą = new System.Windows.Forms.Button();
            this.removeStudentFromTheList = new System.Windows.Forms.Button();
            this.SalinamasStudentasTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // StudentaiListBox
            // 
            this.StudentaiListBox.FormattingEnabled = true;
            this.StudentaiListBox.ItemHeight = 20;
            this.StudentaiListBox.Location = new System.Drawing.Point(28, 79);
            this.StudentaiListBox.Name = "StudentaiListBox";
            this.StudentaiListBox.Size = new System.Drawing.Size(519, 424);
            this.StudentaiListBox.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.AllowDrop = true;
            this.searchButton.Location = new System.Drawing.Point(45, 34);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(165, 29);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Atnaujinti";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // IterptiStudentą
            // 
            this.IterptiStudentą.Location = new System.Drawing.Point(241, 34);
            this.IterptiStudentą.Name = "IterptiStudentą";
            this.IterptiStudentą.Size = new System.Drawing.Size(94, 29);
            this.IterptiStudentą.TabIndex = 4;
            this.IterptiStudentą.Text = "Įterpti";
            this.IterptiStudentą.UseVisualStyleBackColor = true;
            this.IterptiStudentą.Click += new System.EventHandler(this.IterptiStudentą_Click);
            // 
            // removeStudentFromTheList
            // 
            this.removeStudentFromTheList.Location = new System.Drawing.Point(580, 34);
            this.removeStudentFromTheList.Name = "removeStudentFromTheList";
            this.removeStudentFromTheList.Size = new System.Drawing.Size(94, 29);
            this.removeStudentFromTheList.TabIndex = 5;
            this.removeStudentFromTheList.Text = "Šalinti studentą";
            this.removeStudentFromTheList.UseVisualStyleBackColor = true;
            this.removeStudentFromTheList.Click += new System.EventHandler(this.removeStudentFromTheList_Click);
            // 
            // SalinamasStudentasTextBox
            // 
            this.SalinamasStudentasTextBox.Location = new System.Drawing.Point(680, 35);
            this.SalinamasStudentasTextBox.Name = "SalinamasStudentasTextBox";
            this.SalinamasStudentasTextBox.Size = new System.Drawing.Size(125, 27);
            this.SalinamasStudentasTextBox.TabIndex = 6;
            this.SalinamasStudentasTextBox.Text = "studento ID";
            // 
            // studentaiMeniu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 534);
            this.Controls.Add(this.SalinamasStudentasTextBox);
            this.Controls.Add(this.removeStudentFromTheList);
            this.Controls.Add(this.IterptiStudentą);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.StudentaiListBox);
            this.Name = "studentaiMeniu";
            this.Text = "Student panel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox StudentaiListBox;
        private Button searchButton;
        private Button IterptiStudentą;
        private Button removeStudentFromTheList;
        private TextBox SalinamasStudentasTextBox;
    }
}
