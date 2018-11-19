namespace Film
{
    partial class RegistarZanrova
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
            this.btnAddGenre = new System.Windows.Forms.Button();
            this.btnRemoveGenre = new System.Windows.Forms.Button();
            this.tBoxNaziv = new System.Windows.Forms.TextBox();
            this.tBoxOpis = new System.Windows.Forms.TextBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblOpis = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.tBoxID = new System.Windows.Forms.TextBox();
            this.btnUpdateGenre = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddGenre
            // 
            this.btnAddGenre.Location = new System.Drawing.Point(260, 12);
            this.btnAddGenre.Name = "btnAddGenre";
            this.btnAddGenre.Size = new System.Drawing.Size(100, 23);
            this.btnAddGenre.TabIndex = 3;
            this.btnAddGenre.Text = "ADD";
            this.btnAddGenre.UseVisualStyleBackColor = true;
            this.btnAddGenre.Click += new System.EventHandler(this.btnSaveGenre_Click);
            // 
            // btnRemoveGenre
            // 
            this.btnRemoveGenre.Location = new System.Drawing.Point(260, 57);
            this.btnRemoveGenre.Name = "btnRemoveGenre";
            this.btnRemoveGenre.Size = new System.Drawing.Size(100, 23);
            this.btnRemoveGenre.TabIndex = 9;
            this.btnRemoveGenre.Text = "REMOVE";
            this.btnRemoveGenre.UseVisualStyleBackColor = true;
            this.btnRemoveGenre.Click += new System.EventHandler(this.btnRemoveGenre_Click);
            // 
            // tBoxNaziv
            // 
            this.tBoxNaziv.Location = new System.Drawing.Point(77, 44);
            this.tBoxNaziv.Name = "tBoxNaziv";
            this.tBoxNaziv.Size = new System.Drawing.Size(164, 20);
            this.tBoxNaziv.TabIndex = 10;
            // 
            // tBoxOpis
            // 
            this.tBoxOpis.Location = new System.Drawing.Point(77, 79);
            this.tBoxOpis.Multiline = true;
            this.tBoxOpis.Name = "tBoxOpis";
            this.tBoxOpis.Size = new System.Drawing.Size(164, 80);
            this.tBoxOpis.TabIndex = 11;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaziv.Location = new System.Drawing.Point(21, 44);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(51, 20);
            this.lblNaziv.TabIndex = 12;
            this.lblNaziv.Text = "Naziv:";
            this.lblNaziv.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOpis.Location = new System.Drawing.Point(27, 77);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(45, 20);
            this.lblOpis.TabIndex = 13;
            this.lblOpis.Text = "Opis:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblID.Location = new System.Drawing.Point(42, 12);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(30, 20);
            this.lblID.TabIndex = 14;
            this.lblID.Text = "ID:";
            // 
            // tBoxID
            // 
            this.tBoxID.Location = new System.Drawing.Point(77, 12);
            this.tBoxID.Name = "tBoxID";
            this.tBoxID.Size = new System.Drawing.Size(164, 20);
            this.tBoxID.TabIndex = 15;
            // 
            // btnUpdateGenre
            // 
            this.btnUpdateGenre.Location = new System.Drawing.Point(260, 105);
            this.btnUpdateGenre.Name = "btnUpdateGenre";
            this.btnUpdateGenre.Size = new System.Drawing.Size(100, 23);
            this.btnUpdateGenre.TabIndex = 16;
            this.btnUpdateGenre.Text = "UPDATE";
            this.btnUpdateGenre.UseVisualStyleBackColor = true;
            this.btnUpdateGenre.Click += new System.EventHandler(this.btnUpdateGenre_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(78, 165);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(163, 191);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 40);
            this.label1.TabIndex = 18;
            this.label1.Text = "Lista \r\nžanrova:";
            // 
            // RegistarZanrova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 368);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnUpdateGenre);
            this.Controls.Add(this.tBoxID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.tBoxOpis);
            this.Controls.Add(this.tBoxNaziv);
            this.Controls.Add(this.btnRemoveGenre);
            this.Controls.Add(this.btnAddGenre);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(393, 407);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(393, 407);
            this.Name = "RegistarZanrova";
            this.ShowIcon = false;
            this.Text = "RegistarZanrova";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddGenre;
        private System.Windows.Forms.Button btnRemoveGenre;
        private System.Windows.Forms.TextBox tBoxNaziv;
        private System.Windows.Forms.TextBox tBoxOpis;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox tBoxID;
        private System.Windows.Forms.Button btnUpdateGenre;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
    }
}