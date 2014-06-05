using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDodaj_Click(object sender, EventArgs e) 
        {
            double liczba1=double.Parse(textBoxLiczba1.Text);
            double liczba2=double.Parse(textBoxLiczba2.Text);
            double wynik = liczba1 + liczba2;

            textBoxWynik.Text = wynik.ToString();
        }

        private void buttonOdejmij_Click(object sender, EventArgs e)
        {
            double liczba1 = double.Parse(textBoxLiczba1.Text);
            double liczba2 = double.Parse(textBoxLiczba2.Text);
            double wynik = liczba1 - liczba2;

            textBoxWynik.Text = wynik.ToString();
        }

        private void buttonMnoz_Click(object sender, EventArgs e)
        {
            double liczba1 = double.Parse(textBoxLiczba1.Text);
            double liczba2 = double.Parse(textBoxLiczba2.Text);
            double wynik = liczba1 * liczba2;

            textBoxWynik.Text = wynik.ToString();
        }

        private void buttonDziel_Click(object sender, EventArgs e)
        {
            double liczba1 = double.Parse(textBoxLiczba1.Text);
            double liczba2 = double.Parse(textBoxLiczba2.Text);
            double wynik = liczba1 / liczba2;

            textBoxWynik.Text = wynik.ToString();
        }

        private void buttonPotega_Click(object sender, EventArgs e)
        {
            double liczba1 = double.Parse(textBoxLiczba1.Text);
            double liczba2 = double.Parse(textBoxLiczba2.Text);
            double wynik = Math.Pow(liczba1,liczba2);

            textBoxWynik.Text = wynik.ToString();
        }

        private void buttonPierwiastek_Click(object sender, EventArgs e)
        {
            double liczba1 = double.Parse(textBoxLiczba1.Text);
            
            double wynik = Math.Sqrt(liczba1);

            textBoxWynik.Text = wynik.ToString();
        }

        private void zakonczToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

   
     

    
    }
}
