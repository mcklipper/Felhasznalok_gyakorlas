namespace Felhasznalok
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNev = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.btnRogzit = new System.Windows.Forms.Button();
            this.dgvFelhasznalok = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modosit = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFelhasznalok)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név";
            // 
            // tbNev
            // 
            this.tbNev.Location = new System.Drawing.Point(12, 32);
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(166, 27);
            this.tbNev.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "E-Mail cím";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(184, 32);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(166, 27);
            this.tbEmail.TabIndex = 1;
            // 
            // btnRogzit
            // 
            this.btnRogzit.Location = new System.Drawing.Point(356, 31);
            this.btnRogzit.Name = "btnRogzit";
            this.btnRogzit.Size = new System.Drawing.Size(142, 29);
            this.btnRogzit.TabIndex = 2;
            this.btnRogzit.Text = "Rögzítés";
            this.btnRogzit.UseVisualStyleBackColor = true;
            this.btnRogzit.Click += new System.EventHandler(this.btnRogzit_Click);
            // 
            // dgvFelhasznalok
            // 
            this.dgvFelhasznalok.AllowUserToAddRows = false;
            this.dgvFelhasznalok.AllowUserToDeleteRows = false;
            this.dgvFelhasznalok.AllowUserToResizeRows = false;
            this.dgvFelhasznalok.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFelhasznalok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFelhasznalok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nev,
            this.Email,
            this.Modosit});
            this.dgvFelhasznalok.Location = new System.Drawing.Point(12, 65);
            this.dgvFelhasznalok.Name = "dgvFelhasznalok";
            this.dgvFelhasznalok.ReadOnly = true;
            this.dgvFelhasznalok.RowHeadersVisible = false;
            this.dgvFelhasznalok.RowHeadersWidth = 51;
            this.dgvFelhasznalok.RowTemplate.Height = 29;
            this.dgvFelhasznalok.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFelhasznalok.Size = new System.Drawing.Size(601, 373);
            this.dgvFelhasznalok.TabIndex = 3;
            this.dgvFelhasznalok.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFelhasznalok_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Nev
            // 
            this.Nev.HeaderText = "Név";
            this.Nev.MinimumWidth = 6;
            this.Nev.Name = "Nev";
            this.Nev.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "E-Mail cím";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Modosit
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "Módosítás";
            this.Modosit.DefaultCellStyle = dataGridViewCellStyle1;
            this.Modosit.HeaderText = "Módósít";
            this.Modosit.MinimumWidth = 6;
            this.Modosit.Name = "Modosit";
            this.Modosit.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 450);
            this.Controls.Add(this.dgvFelhasznalok);
            this.Controls.Add(this.btnRogzit);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNev);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFelhasznalok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tbNev;
        private Label label2;
        private TextBox tbEmail;
        private Button btnRogzit;
        private DataGridView dgvFelhasznalok;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nev;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewButtonColumn Modosit;
    }
}