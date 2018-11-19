namespace Film
{
    partial class Iznajmljivanje
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
            this.components = new System.ComponentModel.Container();
            this.tBoxKorisnik = new System.Windows.Forms.TextBox();
            this.lblKorisnik = new System.Windows.Forms.Label();
            this.lblFilm = new System.Windows.Forms.Label();
            this.btnIznajmi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tBoxFilm = new System.Windows.Forms.TextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.btnSearchKorisnike = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.btnSearchFilmove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // tBoxKorisnik
            // 
            this.tBoxKorisnik.Location = new System.Drawing.Point(79, 9);
            this.tBoxKorisnik.Name = "tBoxKorisnik";
            this.tBoxKorisnik.Size = new System.Drawing.Size(67, 20);
            this.tBoxKorisnik.TabIndex = 0;
            this.tBoxKorisnik.TextChanged += new System.EventHandler(this.tBoxKorisnik_TextChanged);
            // 
            // lblKorisnik
            // 
            this.lblKorisnik.AutoSize = true;
            this.lblKorisnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKorisnik.Location = new System.Drawing.Point(5, 9);
            this.lblKorisnik.Name = "lblKorisnik";
            this.lblKorisnik.Size = new System.Drawing.Size(68, 20);
            this.lblKorisnik.TabIndex = 3;
            this.lblKorisnik.Text = "Korisnik:";
            this.lblKorisnik.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblFilm
            // 
            this.lblFilm.AutoSize = true;
            this.lblFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFilm.Location = new System.Drawing.Point(31, 56);
            this.lblFilm.Name = "lblFilm";
            this.lblFilm.Size = new System.Drawing.Size(42, 20);
            this.lblFilm.TabIndex = 4;
            this.lblFilm.Text = "Film:";
            // 
            // btnIznajmi
            // 
            this.btnIznajmi.Location = new System.Drawing.Point(228, 26);
            this.btnIznajmi.Name = "btnIznajmi";
            this.btnIznajmi.Size = new System.Drawing.Size(60, 39);
            this.btnIznajmi.TabIndex = 6;
            this.btnIznajmi.Text = "IZNAJMI FILM";
            this.btnIznajmi.UseVisualStyleBackColor = true;
            this.btnIznajmi.Click += new System.EventHandler(this.btnIznajmi_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(313, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 39);
            this.button1.TabIndex = 9;
            this.button1.Text = "VRATI FILM";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tBoxFilm
            // 
            this.tBoxFilm.Location = new System.Drawing.Point(79, 58);
            this.tBoxFilm.Name = "tBoxFilm";
            this.tBoxFilm.Size = new System.Drawing.Size(67, 20);
            this.tBoxFilm.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToResizeColumns = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            this.dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView3.Location = new System.Drawing.Point(12, 91);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(418, 253);
            this.dataGridView3.TabIndex = 12;
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellClick);
            // 
            // btnSearchKorisnike
            // 
            this.btnSearchKorisnike.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearchKorisnike.Image = global::Film.Properties.Resources.search;
            this.btnSearchKorisnike.Location = new System.Drawing.Point(152, 3);
            this.btnSearchKorisnike.Name = "btnSearchKorisnike";
            this.btnSearchKorisnike.Size = new System.Drawing.Size(37, 35);
            this.btnSearchKorisnike.TabIndex = 13;
            this.btnSearchKorisnike.UseVisualStyleBackColor = false;
            this.btnSearchKorisnike.Click += new System.EventHandler(this.btnSearchKorisnike_Click);
            // 
            // btnSearchFilmove
            // 
            this.btnSearchFilmove.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearchFilmove.Image = global::Film.Properties.Resources.search;
            this.btnSearchFilmove.Location = new System.Drawing.Point(152, 50);
            this.btnSearchFilmove.Name = "btnSearchFilmove";
            this.btnSearchFilmove.Size = new System.Drawing.Size(37, 35);
            this.btnSearchFilmove.TabIndex = 14;
            this.btnSearchFilmove.UseVisualStyleBackColor = false;
            this.btnSearchFilmove.Click += new System.EventHandler(this.btnSearchFilmove_Click);
            // 
            // Iznajmljivanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 350);
            this.Controls.Add(this.btnSearchFilmove);
            this.Controls.Add(this.btnSearchKorisnike);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnIznajmi);
            this.Controls.Add(this.lblFilm);
            this.Controls.Add(this.lblKorisnik);
            this.Controls.Add(this.tBoxFilm);
            this.Controls.Add(this.tBoxKorisnik);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(458, 389);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(458, 389);
            this.Name = "Iznajmljivanje";
            this.ShowIcon = false;
            this.Text = "Iznajmljivanje";
            this.Load += new System.EventHandler(this.Iznajmljivanje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxKorisnik;
        private System.Windows.Forms.Label lblKorisnik;
        private System.Windows.Forms.Label lblFilm;
        private System.Windows.Forms.Button btnIznajmi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tBoxFilm;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource bindingSource3;
        private System.Windows.Forms.Button btnSearchKorisnike;
        private System.Windows.Forms.Button btnSearchFilmove;
    }
}