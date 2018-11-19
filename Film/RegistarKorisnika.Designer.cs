namespace Film
{
    partial class RegistarKorisnika
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
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblJMBG = new System.Windows.Forms.Label();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAktivan = new System.Windows.Forms.Label();
            this.tBoxIme = new System.Windows.Forms.TextBox();
            this.tBoxPrezime = new System.Windows.Forms.TextBox();
            this.tBoxJMBG = new System.Windows.Forms.TextBox();
            this.tBoxAdresa = new System.Windows.Forms.TextBox();
            this.tBoxTelefon = new System.Windows.Forms.TextBox();
            this.tBoxEmail = new System.Windows.Forms.TextBox();
            this.cBoxAktivan = new System.Windows.Forms.CheckBox();
            this.btnSaveUser = new System.Windows.Forms.Button();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.lblDug = new System.Windows.Forms.Label();
            this.tBoxDug = new System.Windows.Forms.TextBox();
            this.tBoxID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnListUsers = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBoxFilmova = new System.Windows.Forms.TextBox();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrezime.Location = new System.Drawing.Point(0, 38);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(76, 20);
            this.lblPrezime.TabIndex = 5;
            this.lblPrezime.Text = "*Prezime:";
            // 
            // lblJMBG
            // 
            this.lblJMBG.AutoSize = true;
            this.lblJMBG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblJMBG.Location = new System.Drawing.Point(12, 69);
            this.lblJMBG.Name = "lblJMBG";
            this.lblJMBG.Size = new System.Drawing.Size(64, 20);
            this.lblJMBG.TabIndex = 6;
            this.lblJMBG.Text = "*JMBG:";
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAdresa.Location = new System.Drawing.Point(6, 99);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(70, 20);
            this.lblAdresa.TabIndex = 7;
            this.lblAdresa.Text = "*Adresa:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEmail.Location = new System.Drawing.Point(26, 170);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(50, 20);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "eMail:";
            // 
            // lblAktivan
            // 
            this.lblAktivan.AutoSize = true;
            this.lblAktivan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAktivan.Location = new System.Drawing.Point(5, 226);
            this.lblAktivan.Name = "lblAktivan";
            this.lblAktivan.Size = new System.Drawing.Size(71, 20);
            this.lblAktivan.TabIndex = 11;
            this.lblAktivan.Text = "*Aktivan:";
            // 
            // tBoxIme
            // 
            this.tBoxIme.Location = new System.Drawing.Point(77, 14);
            this.tBoxIme.Name = "tBoxIme";
            this.tBoxIme.Size = new System.Drawing.Size(147, 20);
            this.tBoxIme.TabIndex = 23;
            this.tBoxIme.TextChanged += new System.EventHandler(this.tBoxIme_TextChanged);
            // 
            // tBoxPrezime
            // 
            this.tBoxPrezime.Location = new System.Drawing.Point(77, 40);
            this.tBoxPrezime.Name = "tBoxPrezime";
            this.tBoxPrezime.Size = new System.Drawing.Size(147, 20);
            this.tBoxPrezime.TabIndex = 13;
            this.tBoxPrezime.TextChanged += new System.EventHandler(this.tBoxPrezime_TextChanged);
            // 
            // tBoxJMBG
            // 
            this.tBoxJMBG.Location = new System.Drawing.Point(77, 69);
            this.tBoxJMBG.Name = "tBoxJMBG";
            this.tBoxJMBG.Size = new System.Drawing.Size(147, 20);
            this.tBoxJMBG.TabIndex = 14;
            this.tBoxJMBG.TextChanged += new System.EventHandler(this.tBoxJMBG_TextChanged);
            // 
            // tBoxAdresa
            // 
            this.tBoxAdresa.Location = new System.Drawing.Point(77, 99);
            this.tBoxAdresa.Name = "tBoxAdresa";
            this.tBoxAdresa.Size = new System.Drawing.Size(147, 20);
            this.tBoxAdresa.TabIndex = 15;
            // 
            // tBoxTelefon
            // 
            this.tBoxTelefon.Location = new System.Drawing.Point(77, 133);
            this.tBoxTelefon.Name = "tBoxTelefon";
            this.tBoxTelefon.Size = new System.Drawing.Size(147, 20);
            this.tBoxTelefon.TabIndex = 16;
            // 
            // tBoxEmail
            // 
            this.tBoxEmail.Location = new System.Drawing.Point(77, 170);
            this.tBoxEmail.Name = "tBoxEmail";
            this.tBoxEmail.Size = new System.Drawing.Size(147, 20);
            this.tBoxEmail.TabIndex = 17;
            // 
            // cBoxAktivan
            // 
            this.cBoxAktivan.AutoSize = true;
            this.cBoxAktivan.Location = new System.Drawing.Point(147, 231);
            this.cBoxAktivan.Name = "cBoxAktivan";
            this.cBoxAktivan.Size = new System.Drawing.Size(15, 14);
            this.cBoxAktivan.TabIndex = 19;
            this.cBoxAktivan.UseVisualStyleBackColor = true;
            this.cBoxAktivan.CheckedChanged += new System.EventHandler(this.cBoxAktivan_CheckedChanged);
            // 
            // btnSaveUser
            // 
            this.btnSaveUser.Location = new System.Drawing.Point(245, 177);
            this.btnSaveUser.Name = "btnSaveUser";
            this.btnSaveUser.Size = new System.Drawing.Size(75, 40);
            this.btnSaveUser.TabIndex = 21;
            this.btnSaveUser.Text = "UPDATE USER";
            this.btnSaveUser.UseVisualStyleBackColor = true;
            this.btnSaveUser.Click += new System.EventHandler(this.btnSaveUser_Click);
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIme.Location = new System.Drawing.Point(25, 14);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(46, 20);
            this.lblIme.TabIndex = 24;
            this.lblIme.Text = "*Ime:";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTelefon.Location = new System.Drawing.Point(4, 133);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(72, 20);
            this.lblTelefon.TabIndex = 26;
            this.lblTelefon.Text = "*Telefon:";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(245, 69);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(75, 40);
            this.btnAddUser.TabIndex = 27;
            this.btnAddUser.Text = "ADD NEW USER";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // lblDug
            // 
            this.lblDug.AutoSize = true;
            this.lblDug.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDug.Location = new System.Drawing.Point(33, 196);
            this.lblDug.Name = "lblDug";
            this.lblDug.Size = new System.Drawing.Size(43, 20);
            this.lblDug.TabIndex = 28;
            this.lblDug.Text = "Dug:";
            // 
            // tBoxDug
            // 
            this.tBoxDug.Location = new System.Drawing.Point(77, 196);
            this.tBoxDug.Name = "tBoxDug";
            this.tBoxDug.Size = new System.Drawing.Size(147, 20);
            this.tBoxDug.TabIndex = 32;
            this.tBoxDug.TextChanged += new System.EventHandler(this.tBoxDug_TextChanged_1);
            // 
            // tBoxID
            // 
            this.tBoxID.Location = new System.Drawing.Point(243, 233);
            this.tBoxID.Name = "tBoxID";
            this.tBoxID.Size = new System.Drawing.Size(77, 20);
            this.tBoxID.TabIndex = 30;
            this.tBoxID.Visible = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblID.Location = new System.Drawing.Point(194, 231);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(30, 20);
            this.lblID.TabIndex = 31;
            this.lblID.Text = "ID:";
            this.lblID.Visible = false;
            // 
            // btnListUsers
            // 
            this.btnListUsers.Location = new System.Drawing.Point(245, 283);
            this.btnListUsers.Name = "btnListUsers";
            this.btnListUsers.Size = new System.Drawing.Size(75, 43);
            this.btnListUsers.TabIndex = 33;
            this.btnListUsers.Text = "LIST USERS";
            this.btnListUsers.UseVisualStyleBackColor = true;
            this.btnListUsers.Click += new System.EventHandler(this.btnListUsers_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(245, 18);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 40);
            this.btnRefresh.TabIndex = 34;
            this.btnRefresh.Text = "REFRESH FIELDS";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(7, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 32);
            this.label1.TabIndex = 35;
            this.label1.Text = "Polja sa * znakom \r\nsu obavezna.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(13, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "Filmova podignuto trenutno:";
            // 
            // tBoxFilmova
            // 
            this.tBoxFilmova.Location = new System.Drawing.Point(191, 257);
            this.tBoxFilmova.Name = "tBoxFilmova";
            this.tBoxFilmova.ReadOnly = true;
            this.tBoxFilmova.Size = new System.Drawing.Size(53, 20);
            this.tBoxFilmova.TabIndex = 38;
            this.tBoxFilmova.TextChanged += new System.EventHandler(this.tBoxFilmova_TextChanged);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(245, 115);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(75, 51);
            this.btnDeleteUser.TabIndex = 39;
            this.btnDeleteUser.Text = "DELETE USER";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // RegistarKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 329);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.tBoxFilmova);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnListUsers);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.tBoxID);
            this.Controls.Add(this.tBoxDug);
            this.Controls.Add(this.lblDug);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.btnSaveUser);
            this.Controls.Add(this.cBoxAktivan);
            this.Controls.Add(this.tBoxEmail);
            this.Controls.Add(this.tBoxTelefon);
            this.Controls.Add(this.tBoxAdresa);
            this.Controls.Add(this.tBoxJMBG);
            this.Controls.Add(this.tBoxPrezime);
            this.Controls.Add(this.tBoxIme);
            this.Controls.Add(this.lblAktivan);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.lblJMBG);
            this.Controls.Add(this.lblPrezime);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(349, 368);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(349, 368);
            this.Name = "RegistarKorisnika";
            this.ShowIcon = false;
            this.Text = "RegistarKorisnika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblJMBG;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAktivan;
        private System.Windows.Forms.TextBox tBoxIme;
        private System.Windows.Forms.TextBox tBoxPrezime;
        private System.Windows.Forms.TextBox tBoxJMBG;
        private System.Windows.Forms.TextBox tBoxAdresa;
        private System.Windows.Forms.TextBox tBoxTelefon;
        private System.Windows.Forms.TextBox tBoxEmail;
        private System.Windows.Forms.CheckBox cBoxAktivan;
        private System.Windows.Forms.Button btnSaveUser;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label lblDug;
        private System.Windows.Forms.TextBox tBoxDug;
        private System.Windows.Forms.TextBox tBoxID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnListUsers;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBoxFilmova;
        private System.Windows.Forms.Button btnDeleteUser;
    }
}