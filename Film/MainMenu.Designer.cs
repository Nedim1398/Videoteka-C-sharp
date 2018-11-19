namespace Film
{
    partial class MainMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnIznajmljivanje = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnMovies = new System.Windows.Forms.Button();
            this.btnGenres = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Radnik:";
            // 
            // btnIznajmljivanje
            // 
            this.btnIznajmljivanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIznajmljivanje.Location = new System.Drawing.Point(16, 77);
            this.btnIznajmljivanje.Name = "btnIznajmljivanje";
            this.btnIznajmljivanje.Size = new System.Drawing.Size(105, 42);
            this.btnIznajmljivanje.TabIndex = 2;
            this.btnIznajmljivanje.Text = "Iznajmljivanje";
            this.btnIznajmljivanje.UseVisualStyleBackColor = true;
            this.btnIznajmljivanje.Click += new System.EventHandler(this.btnIznajmljivanje_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUsers.Location = new System.Drawing.Point(151, 77);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(105, 42);
            this.btnUsers.TabIndex = 3;
            this.btnUsers.Text = "Korisnici";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnMovies
            // 
            this.btnMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMovies.Location = new System.Drawing.Point(16, 144);
            this.btnMovies.Name = "btnMovies";
            this.btnMovies.Size = new System.Drawing.Size(105, 42);
            this.btnMovies.TabIndex = 4;
            this.btnMovies.Text = "Filmovi";
            this.btnMovies.UseVisualStyleBackColor = true;
            this.btnMovies.Click += new System.EventHandler(this.btnMovies_Click);
            // 
            // btnGenres
            // 
            this.btnGenres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGenres.Location = new System.Drawing.Point(151, 144);
            this.btnGenres.Name = "btnGenres";
            this.btnGenres.Size = new System.Drawing.Size(105, 42);
            this.btnGenres.TabIndex = 5;
            this.btnGenres.Text = "Žanrovi";
            this.btnGenres.UseVisualStyleBackColor = true;
            this.btnGenres.Click += new System.EventHandler(this.btnGenres_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(16, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(54, 21);
            this.button5.TabIndex = 6;
            this.button5.Text = "Odjava";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(172, 20);
            this.textBox1.TabIndex = 7;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 224);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnGenres);
            this.Controls.Add(this.btnMovies);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.btnIznajmljivanje);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(296, 263);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(296, 263);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIznajmljivanje;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnMovies;
        private System.Windows.Forms.Button btnGenres;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
    }
}