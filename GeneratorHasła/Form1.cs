using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneratorHasła
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            stanowiskoCombo.Items.Add("Tester");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        string hasło = " ";
        private void button1_Click(object sender, EventArgs e)
        {
            //losowanie znaków

            Random rand = new Random();
            int GetNumber()
            {
                int rInt = rand.Next(0, 9);
                return rInt;
            }

            char GetLetter()
            {
                string letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
                int num = rand.Next(0, letters.Length);
                return letters[num];
            }
            char GetSpecial()
            {
                string specials = "!@#$%^&*()_+-=";              
                int num = rand.Next(0, specials.Length);
                return specials[num];
            }

            //Pobieranie wartości dla hasła
            int iloscZnakow = 0;
            try
            {
                iloscZnakow = Convert.ToInt32(liczbaZnakowTB.Text);
            }
            catch(FormatException) 
            { 
                MessageBox.Show("Nie wpisałeś ile znaków!"); 
            }

            //wyznaczenie hasła
            
            for (int x = 0; x < iloscZnakow; x++)
            {

                if (lettersCB.Checked)
                {
                    hasło = hasło + Convert.ToString(GetLetter());
                }
                if (specialCB.Checked)
                {
                    hasło = hasło + Convert.ToString(GetSpecial());
                }
                if (numbersCB.Checked)
                {
                    hasło = hasło + Convert.ToString(GetNumber());
                }
                
            }
            try 
            {
                if (iloscZnakow != 0)
                {
                    
                    MessageBox.Show("Dane Pracownika: " + ImieTB.Text + " " +NazwiskoTB.Text+" "+ stanowiskoCombo.Text + " Hasło:" + hasło.Substring(0, iloscZnakow + 1));
                }
            }
            catch (ArgumentOutOfRangeException) { MessageBox.Show("Nie zaznaczyłeś żadnego pola wyboru!"); }
            
    }

        void Accept_Click(object sender, EventArgs e) 
        {
            if (liczbaZnakowTB.Text!=string.Empty && ImieTB.Text != string.Empty && NazwiskoLB.Text!=string.Empty)
            {
                if (lettersCB.Checked || numbersCB.Checked || specialCB.Checked)
                {
                    MessageBox.Show("Dane Pracownika: " + ImieTB.Text + " " + NazwiskoTB.Text + " " + stanowiskoCombo.Text + " Hasło:" + hasło);
                }
                else { MessageBox.Show("Wybierz znaki dla hasła"); }
            }
            else
            {
                MessageBox.Show("Wypełnij wszystkie pola");
            }
        }
        
    }
}
