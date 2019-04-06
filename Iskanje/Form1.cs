using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iskanje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Tab tabela = new Tab();
        private void dodajButton_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(vnosTextBox.Text);
                tabela.Dodaj(x);
                outputLabel.Text = tabela.ToString();
            }
            catch
            {
                MessageBox.Show("Error!!!");
            }
        }
        private void vsebujeButton_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(vnosTextBox.Text);
                if (tabela.Vsebuje(x) == true) MessageBox.Show("Tabela vsebuje " + x +".");
                else MessageBox.Show("Tabela ne vsebuje " + x + ".");
            }
            catch { MessageBox.Show("Error!!!"); }
        }

        private void vsBinarButton_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(vnosTextBox.Text);
                if(tabela.VsebujeBinarno(x) == true) MessageBox.Show("Tabela vsebuje " + x + ".");
                else MessageBox.Show("Tabela ne vsebuje " + x + ".");
            }
            catch { MessageBox.Show("Error!!!"); }
        }

        private void minButton_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Minimum: " + tabela.Min() + ".");
            }
            catch { MessageBox.Show("Error!!!"); }
        }

        private void maxButton_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Maximum: " + tabela.Max() + ".");
            }
            catch { MessageBox.Show("Error!!!"); }
        }

        private void vsotaButton_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Vsota: " + tabela.Vsota() + ".");
            }
            catch { MessageBox.Show("Error!!!"); }
        }

        private void povpButton_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Povprečje: " + tabela.Povprecje().ToString() + ".");
            }
            catch { MessageBox.Show("Error!!!"); }
        }
    }
    public class Tab
    {
        private int[] Tabela = new int[100];
        public int Dolzina { get; set; }
        public Tab()
        {

        }
        public void Dodaj(int x)
        {
            Tabela[Dolzina] = x;
            Dolzina++;
        }
        public bool Vsebuje(int x)
        {
            bool vs = false;
            for (int i = 0; i < Dolzina; i++)
            {
                if (x == Tabela[i])
                {
                    return vs = true;
                }
            }
            return vs;
        }
        public override string ToString()
        {
            string tab="";
            for (int i = 0; i < Dolzina; i++)
            {
                tab = tab + Tabela[i] + ", ";
            }
            return tab;
        }
        public int Vsota()
        {
            int vs = 0;
            for (int i = 0; i < Dolzina; i++)
            {
                vs += Tabela[i];
            }
            return vs;
        }
        public int Min()
        {
            int min = Tabela[0];
            for (int i = 0; i < Dolzina; i++)
            {
                if (Tabela[i] < min) min = Tabela[i];
            }
            return min;
        }
        public int Max()
        {
            int max = Tabela[0];
            for (int i = 0; i < Dolzina; i++)
            {
                if (Tabela[i] > max) max = Tabela[i];
            }
            return max;
        }
        public float Povprecje()
        {
            return (float)Vsota() / Dolzina; 
        }
        public bool VsebujeBinarno(int x)
        {
            bool binVs = false;
            int min = 0, max = Dolzina-1;
            while (min <= max) 
            {
                int mid = (min + max) / 2;
                if (x > Tabela[mid]) min = mid + 1;
                else if (x < Tabela[mid]) max = mid - 1;
                else if (x == Tabela[mid]) return binVs = true;
            }
            return binVs;
        }
    }
}
