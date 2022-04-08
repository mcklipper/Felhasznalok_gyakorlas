namespace Felhasznalok
{
    partial class UpdateForm
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
            this.btnModosit = new System.Windows.Forms.Button();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNev = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnModosit
            // 
            this.btnModosit.Location = new System.Drawing.Point(356, 31);
            this.btnModosit.Name = "btnModosit";
            this.btnModosit.Size = new System.Drawing.Size(142, 29);
            this.btnModosit.TabIndex = 7;
            this.btnModosit.Text = "Módosítás";
            this.btnModosit.UseVisualStyleBackColor = true;
            this.btnModosit.Click += new System.EventHandler(this.btnModosit_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(184, 32);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(166, 27);
            this.tbEmail.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "E-Mail cím";
            // 
            // tbNev
            // 
            this.tbNev.Location = new System.Drawing.Point(12, 32);
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(166, 27);
            this.tbNev.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Név";
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 76);
            this.Controls.Add(this.btnModosit);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNev);
            this.Controls.Add(this.label1);
            this.Name = "UpdateForm";
            this.Text = "UpdateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnModosit;
        private TextBox tbEmail;
        private Label label2;
        private TextBox tbNev;
        private Label label1;
    }
}