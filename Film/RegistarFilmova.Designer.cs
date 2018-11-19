namespace Film
{
    partial class RegistarFilmova
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
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblStanje = new System.Windows.Forms.Label();
            this.lblTrajanje = new System.Windows.Forms.Label();
            this.lblTip = new System.Windows.Forms.Label();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.tBoxNaziv = new System.Windows.Forms.TextBox();
            this.btnSaveMovies = new System.Windows.Forms.Button();
            this.tBoxStanje = new System.Windows.Forms.TextBox();
            this.tBoxTrajanje = new System.Windows.Forms.TextBox();
            this.tBoxTip = new System.Windows.Forms.TextBox();
            this.lblBroj = new System.Windows.Forms.Label();
            this.tBoxBroj = new System.Windows.Forms.TextBox();
            this.btnListMovies = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaziv.Location = new System.Drawing.Point(24, 12);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(57, 20);
            this.lblNaziv.TabIndex = 0;
            this.lblNaziv.Text = "*Naziv:";
            // 
            // lblStanje
            // 
            this.lblStanje.AutoSize = true;
            this.lblStanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStanje.Location = new System.Drawing.Point(16, 46);
            this.lblStanje.Name = "lblStanje";
            this.lblStanje.Size = new System.Drawing.Size(65, 20);
            this.lblStanje.TabIndex = 2;
            this.lblStanje.Text = "*Stanje:";
            // 
            // lblTrajanje
            // 
            this.lblTrajanje.AutoSize = true;
            this.lblTrajanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTrajanje.Location = new System.Drawing.Point(5, 78);
            this.lblTrajanje.Name = "lblTrajanje";
            this.lblTrajanje.Size = new System.Drawing.Size(75, 20);
            this.lblTrajanje.TabIndex = 3;
            this.lblTrajanje.Text = "*Trajanje:";
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTip.Location = new System.Drawing.Point(40, 108);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(40, 20);
            this.lblTip.TabIndex = 4;
            this.lblTip.Text = "*Tip:";
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Location = new System.Drawing.Point(12, 141);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(62, 38);
            this.btnAddMovie.TabIndex = 17;
            this.btnAddMovie.Text = "ADD MOVIE";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // tBoxNaziv
            // 
            this.tBoxNaziv.Location = new System.Drawing.Point(89, 12);
            this.tBoxNaziv.Name = "tBoxNaziv";
            this.tBoxNaziv.Size = new System.Drawing.Size(228, 20);
            this.tBoxNaziv.TabIndex = 18;
            // 
            // btnSaveMovies
            // 
            this.btnSaveMovies.Location = new System.Drawing.Point(91, 141);
            this.btnSaveMovies.Name = "btnSaveMovies";
            this.btnSaveMovies.Size = new System.Drawing.Size(64, 38);
            this.btnSaveMovies.TabIndex = 19;
            this.btnSaveMovies.Text = "UPDATE MOVIE";
            this.btnSaveMovies.UseVisualStyleBackColor = true;
            this.btnSaveMovies.Click += new System.EventHandler(this.btnSaveMovies_Click);
            // 
            // tBoxStanje
            // 
            this.tBoxStanje.Location = new System.Drawing.Point(89, 46);
            this.tBoxStanje.Name = "tBoxStanje";
            this.tBoxStanje.Size = new System.Drawing.Size(228, 20);
            this.tBoxStanje.TabIndex = 20;
            // 
            // tBoxTrajanje
            // 
            this.tBoxTrajanje.Location = new System.Drawing.Point(89, 78);
            this.tBoxTrajanje.Name = "tBoxTrajanje";
            this.tBoxTrajanje.Size = new System.Drawing.Size(228, 20);
            this.tBoxTrajanje.TabIndex = 21;
            // 
            // tBoxTip
            // 
            this.tBoxTip.Location = new System.Drawing.Point(89, 110);
            this.tBoxTip.Name = "tBoxTip";
            this.tBoxTip.Size = new System.Drawing.Size(228, 20);
            this.tBoxTip.TabIndex = 22;
            // 
            // lblBroj
            // 
            this.lblBroj.AutoSize = true;
            this.lblBroj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBroj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBroj.Location = new System.Drawing.Point(323, 182);
            this.lblBroj.Name = "lblBroj";
            this.lblBroj.Size = new System.Drawing.Size(43, 22);
            this.lblBroj.TabIndex = 23;
            this.lblBroj.Text = "Broj:";
            this.lblBroj.Visible = false;
            // 
            // tBoxBroj
            // 
            this.tBoxBroj.Location = new System.Drawing.Point(372, 184);
            this.tBoxBroj.Name = "tBoxBroj";
            this.tBoxBroj.Size = new System.Drawing.Size(100, 20);
            this.tBoxBroj.TabIndex = 24;
            this.tBoxBroj.Visible = false;
            // 
            // btnListMovies
            // 
            this.btnListMovies.Location = new System.Drawing.Point(258, 141);
            this.btnListMovies.Name = "btnListMovies";
            this.btnListMovies.Size = new System.Drawing.Size(61, 38);
            this.btnListMovies.TabIndex = 25;
            this.btnListMovies.Text = "LIST MOVIES";
            this.btnListMovies.UseVisualStyleBackColor = true;
            this.btnListMovies.Click += new System.EventHandler(this.btnListMovies_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(323, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(170, 167);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(173, 141);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(67, 38);
            this.btnRefresh.TabIndex = 27;
            this.btnRefresh.Text = "REFRESH FIELDS";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(25, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Sva polja sa * znakom su obavezna.";
            // 
            // RegistarFilmova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 209);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnListMovies);
            this.Controls.Add(this.tBoxBroj);
            this.Controls.Add(this.lblBroj);
            this.Controls.Add(this.tBoxTip);
            this.Controls.Add(this.tBoxTrajanje);
            this.Controls.Add(this.tBoxStanje);
            this.Controls.Add(this.btnSaveMovies);
            this.Controls.Add(this.tBoxNaziv);
            this.Controls.Add(this.btnAddMovie);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.lblTrajanje);
            this.Controls.Add(this.lblStanje);
            this.Controls.Add(this.lblNaziv);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(530, 248);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(530, 248);
            this.Name = "RegistarFilmova";
            this.ShowIcon = false;
            this.Text = "RegistarFilmova";
            this.Load += new System.EventHandler(this.RegistarFilmova_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblStanje;
        private System.Windows.Forms.Label lblTrajanje;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.TextBox tBoxNaziv;
        private System.Windows.Forms.Button btnSaveMovies;
        private System.Windows.Forms.TextBox tBoxStanje;
        private System.Windows.Forms.TextBox tBoxTrajanje;
        private System.Windows.Forms.TextBox tBoxTip;
        private System.Windows.Forms.Label lblBroj;
        private System.Windows.Forms.TextBox tBoxBroj;
        private System.Windows.Forms.Button btnListMovies;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label1;
    }
}