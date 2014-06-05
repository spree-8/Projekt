namespace Kalkulator
{
    partial class Form1
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
            this.labelLiczba1 = new System.Windows.Forms.Label();
            this.labelLiczba2 = new System.Windows.Forms.Label();
            this.labelWynik = new System.Windows.Forms.Label();
            this.textBoxLiczba1 = new System.Windows.Forms.TextBox();
            this.textBoxLiczba2 = new System.Windows.Forms.TextBox();
            this.textBoxWynik = new System.Windows.Forms.TextBox();
            this.labelDzialanie = new System.Windows.Forms.Label();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonMnoz = new System.Windows.Forms.Button();
            this.buttonOdejmij = new System.Windows.Forms.Button();
            this.buttonDziel = new System.Windows.Forms.Button();
            this.buttonPotega = new System.Windows.Forms.Button();
            this.buttonPierwiastek = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakonczToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dzialaniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odejmijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnozToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dzielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.potegaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pierwiastekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelLiczba1
            // 
            this.labelLiczba1.AutoSize = true;
            this.labelLiczba1.ForeColor = System.Drawing.Color.Blue;
            this.labelLiczba1.Location = new System.Drawing.Point(12, 39);
            this.labelLiczba1.Name = "labelLiczba1";
            this.labelLiczba1.Size = new System.Drawing.Size(47, 13);
            this.labelLiczba1.TabIndex = 0;
            this.labelLiczba1.Text = "Liczba 1";
            // 
            // labelLiczba2
            // 
            this.labelLiczba2.AutoSize = true;
            this.labelLiczba2.ForeColor = System.Drawing.Color.Blue;
            this.labelLiczba2.Location = new System.Drawing.Point(12, 78);
            this.labelLiczba2.Name = "labelLiczba2";
            this.labelLiczba2.Size = new System.Drawing.Size(47, 13);
            this.labelLiczba2.TabIndex = 1;
            this.labelLiczba2.Text = "Liczba 2";
            // 
            // labelWynik
            // 
            this.labelWynik.AutoSize = true;
            this.labelWynik.ForeColor = System.Drawing.Color.Blue;
            this.labelWynik.Location = new System.Drawing.Point(16, 113);
            this.labelWynik.Name = "labelWynik";
            this.labelWynik.Size = new System.Drawing.Size(37, 13);
            this.labelWynik.TabIndex = 2;
            this.labelWynik.Text = "Wynik";
            // 
            // textBoxLiczba1
            // 
            this.textBoxLiczba1.Location = new System.Drawing.Point(94, 39);
            this.textBoxLiczba1.Name = "textBoxLiczba1";
            this.textBoxLiczba1.Size = new System.Drawing.Size(100, 20);
            this.textBoxLiczba1.TabIndex = 3;
            // 
            // textBoxLiczba2
            // 
            this.textBoxLiczba2.Location = new System.Drawing.Point(94, 78);
            this.textBoxLiczba2.Name = "textBoxLiczba2";
            this.textBoxLiczba2.Size = new System.Drawing.Size(100, 20);
            this.textBoxLiczba2.TabIndex = 4;
            // 
            // textBoxWynik
            // 
            this.textBoxWynik.Location = new System.Drawing.Point(94, 113);
            this.textBoxWynik.Name = "textBoxWynik";
            this.textBoxWynik.Size = new System.Drawing.Size(100, 20);
            this.textBoxWynik.TabIndex = 5;
            // 
            // labelDzialanie
            // 
            this.labelDzialanie.AutoSize = true;
            this.labelDzialanie.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDzialanie.ForeColor = System.Drawing.Color.Maroon;
            this.labelDzialanie.Location = new System.Drawing.Point(14, 152);
            this.labelDzialanie.Name = "labelDzialanie";
            this.labelDzialanie.Size = new System.Drawing.Size(100, 26);
            this.labelDzialanie.TabIndex = 6;
            this.labelDzialanie.Text = "Działanie: ";
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(19, 200);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(58, 23);
            this.buttonDodaj.TabIndex = 7;
            this.buttonDodaj.Text = "+";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonMnoz
            // 
            this.buttonMnoz.Location = new System.Drawing.Point(19, 254);
            this.buttonMnoz.Name = "buttonMnoz";
            this.buttonMnoz.Size = new System.Drawing.Size(61, 23);
            this.buttonMnoz.TabIndex = 8;
            this.buttonMnoz.Text = "*";
            this.buttonMnoz.UseVisualStyleBackColor = true;
            this.buttonMnoz.Click += new System.EventHandler(this.buttonMnoz_Click);
            // 
            // buttonOdejmij
            // 
            this.buttonOdejmij.Location = new System.Drawing.Point(94, 200);
            this.buttonOdejmij.Name = "buttonOdejmij";
            this.buttonOdejmij.Size = new System.Drawing.Size(58, 23);
            this.buttonOdejmij.TabIndex = 9;
            this.buttonOdejmij.Text = "-";
            this.buttonOdejmij.UseVisualStyleBackColor = true;
            this.buttonOdejmij.Click += new System.EventHandler(this.buttonOdejmij_Click);
            // 
            // buttonDziel
            // 
            this.buttonDziel.Location = new System.Drawing.Point(94, 254);
            this.buttonDziel.Name = "buttonDziel";
            this.buttonDziel.Size = new System.Drawing.Size(58, 23);
            this.buttonDziel.TabIndex = 10;
            this.buttonDziel.Text = "/";
            this.buttonDziel.UseVisualStyleBackColor = true;
            this.buttonDziel.Click += new System.EventHandler(this.buttonDziel_Click);
            // 
            // buttonPotega
            // 
            this.buttonPotega.Location = new System.Drawing.Point(172, 200);
            this.buttonPotega.Name = "buttonPotega";
            this.buttonPotega.Size = new System.Drawing.Size(67, 23);
            this.buttonPotega.TabIndex = 11;
            this.buttonPotega.Text = "potęga";
            this.buttonPotega.UseVisualStyleBackColor = true;
            this.buttonPotega.Click += new System.EventHandler(this.buttonPotega_Click);
            // 
            // buttonPierwiastek
            // 
            this.buttonPierwiastek.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPierwiastek.Location = new System.Drawing.Point(172, 255);
            this.buttonPierwiastek.Name = "buttonPierwiastek";
            this.buttonPierwiastek.Size = new System.Drawing.Size(67, 23);
            this.buttonPierwiastek.TabIndex = 12;
            this.buttonPierwiastek.Text = "pierwiastek";
            this.buttonPierwiastek.UseVisualStyleBackColor = true;
            this.buttonPierwiastek.Click += new System.EventHandler(this.buttonPierwiastek_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.dzialaniaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zakonczToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(34, 20);
            this.plikToolStripMenuItem.Text = "&Plik";
            // 
            // zakonczToolStripMenuItem
            // 
            this.zakonczToolStripMenuItem.Name = "zakonczToolStripMenuItem";
            this.zakonczToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.zakonczToolStripMenuItem.Text = "&Zakończ";
            this.zakonczToolStripMenuItem.Click += new System.EventHandler(this.zakonczToolStripMenuItem_Click);
            // 
            // dzialaniaToolStripMenuItem
            // 
            this.dzialaniaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajToolStripMenuItem,
            this.odejmijToolStripMenuItem,
            this.mnozToolStripMenuItem,
            this.dzielToolStripMenuItem,
            this.potegaToolStripMenuItem,
            this.pierwiastekToolStripMenuItem});
            this.dzialaniaToolStripMenuItem.Name = "dzialaniaToolStripMenuItem";
            this.dzialaniaToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.dzialaniaToolStripMenuItem.Text = "&Działania";
            // 
            // dodajToolStripMenuItem
            // 
            this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            this.dodajToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.dodajToolStripMenuItem.Text = "&Dodaj";
            this.dodajToolStripMenuItem.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // odejmijToolStripMenuItem
            // 
            this.odejmijToolStripMenuItem.Name = "odejmijToolStripMenuItem";
            this.odejmijToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.odejmijToolStripMenuItem.Text = "&Odejmij";
            this.odejmijToolStripMenuItem.Click += new System.EventHandler(this.buttonOdejmij_Click);
            // 
            // mnozToolStripMenuItem
            // 
            this.mnozToolStripMenuItem.Name = "mnozToolStripMenuItem";
            this.mnozToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.mnozToolStripMenuItem.Text = "&Mnóż";
            this.mnozToolStripMenuItem.Click += new System.EventHandler(this.buttonMnoz_Click);
            // 
            // dzielToolStripMenuItem
            // 
            this.dzielToolStripMenuItem.Name = "dzielToolStripMenuItem";
            this.dzielToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.dzielToolStripMenuItem.Text = "D&ziel";
            this.dzielToolStripMenuItem.Click += new System.EventHandler(this.buttonDziel_Click);
            // 
            // potegaToolStripMenuItem
            // 
            this.potegaToolStripMenuItem.Name = "potegaToolStripMenuItem";
            this.potegaToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.potegaToolStripMenuItem.Text = "&Potęga";
            this.potegaToolStripMenuItem.Click += new System.EventHandler(this.buttonPotega_Click);
            // 
            // pierwiastekToolStripMenuItem
            // 
            this.pierwiastekToolStripMenuItem.Name = "pierwiastekToolStripMenuItem";
            this.pierwiastekToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.pierwiastekToolStripMenuItem.Text = "Pie&rwiastek";
            this.pierwiastekToolStripMenuItem.Click += new System.EventHandler(this.buttonPierwiastek_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 360);
            this.Controls.Add(this.buttonPierwiastek);
            this.Controls.Add(this.buttonPotega);
            this.Controls.Add(this.buttonDziel);
            this.Controls.Add(this.buttonOdejmij);
            this.Controls.Add(this.buttonMnoz);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.labelDzialanie);
            this.Controls.Add(this.textBoxWynik);
            this.Controls.Add(this.textBoxLiczba2);
            this.Controls.Add(this.textBoxLiczba1);
            this.Controls.Add(this.labelWynik);
            this.Controls.Add(this.labelLiczba2);
            this.Controls.Add(this.labelLiczba1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLiczba1;
        private System.Windows.Forms.Label labelLiczba2;
        private System.Windows.Forms.Label labelWynik;
        private System.Windows.Forms.TextBox textBoxLiczba1;
        private System.Windows.Forms.TextBox textBoxLiczba2;
        private System.Windows.Forms.TextBox textBoxWynik;
        private System.Windows.Forms.Label labelDzialanie;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonMnoz;
        private System.Windows.Forms.Button buttonOdejmij;
        private System.Windows.Forms.Button buttonDziel;
        private System.Windows.Forms.Button buttonPotega;
        private System.Windows.Forms.Button buttonPierwiastek;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakonczToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dzialaniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odejmijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnozToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dzielToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem potegaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pierwiastekToolStripMenuItem;
    }
}

