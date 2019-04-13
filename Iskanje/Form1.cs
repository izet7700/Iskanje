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

        private void urediVstButton_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(vnosTextBox.Text);
                float fun = tabela.UrediVstav(x);
                MessageBox.Show("Urejeno \nČas(milisecond): " + fun.ToString());
                outputLabel.Text = tabela.ToString();
            }
            catch { MessageBox.Show("Error"); }
        }

        private void urediIzbButton_Click(object sender, EventArgs e)
        {
            try
            {
                float fun = tabela.UrediIzb();
                MessageBox.Show("Urejeno \nČas(milisecond): " + fun.ToString());
                outputLabel.Text = tabela.ToString();
            }
            catch { MessageBox.Show("Error"); }
        }

        private void urediMehButton_Click(object sender, EventArgs e)
        {
            try
            {
                float fun = tabela.UrediMehurčki();
                MessageBox.Show("Urejeno \nČas(milisecond): " + fun.ToString());
                outputLabel.Text = tabela.ToString();
            }
            catch { MessageBox.Show("Error"); }
        }

        private void hitUredButton_Click(object sender, EventArgs e)
        {
            try
            {
                var watch = System.Diagnostics.Stopwatch.StartNew();
                watch.Start();
                tabela.QuickSort(0, tabela.Dolzina-1);
                watch.Stop();
                MessageBox.Show("Urejeno\nČas(milisecond): " + watch.Elapsed.TotalMilliseconds.ToString());
                outputLabel.Text = tabela.ToString();
            }
            catch { MessageBox.Show("Error"); }
        }

        private void napolniButton_Click(object sender, EventArgs e)
        {
            tabela.Napolni();
            MessageBox.Show("Napolnjeno");
            outputLabel.Text = tabela.ToString();
        }
    }
    public class Tab
    {
        private int[] Tabela = new int[100];
        public int Dolzina { get; set; }
        public Tab()
        {
            Dolzina = 0;
            for (int i = 0; i <= 99; i++) Tabela[i] = 0;
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
            string tab = "";
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
            int min = 0, max = Dolzina - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (x > Tabela[mid]) min = mid + 1;
                else if (x < Tabela[mid]) max = mid - 1;
                else if (x == Tabela[mid]) return binVs = true;
            }
            return binVs;
        }
        public string Uredi()
        {
            Array.Sort(Tabela);
            string urejeno="";
            foreach (int st in Tabela)
            {
                urejeno = urejeno + st + ", ";
            }
            return urejeno;
        }
        public float UrediVstav(int x)
        {
            Dodaj(x);
            var watch = System.Diagnostics.Stopwatch.StartNew();
            watch.Start();
            int val, pre;
            for(int i=1; i < Dolzina; i++)
            {
                val = Tabela[i];
                pre = 0;
                for(int j=i-1;j>=0 && pre != 1;)
                {
                    if (val < Tabela[j])
                    {
                        Tabela[j + 1] = Tabela[j];
                        j--;
                        Tabela[j + 1] = val;
                    }
                    else pre = 1;
                }
            }
            watch.Stop();
            return (float) watch.Elapsed.TotalMilliseconds;
        }
        public float UrediMehurčki()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            watch.Start();
            int temp, i, j;
            for (i = 0; i <= Dolzina-2; i++)
            {
                for (j = 0; j <= Dolzina-2; j++)
                {
                    if (Tabela[j] > Tabela[j + 1])
                    {
                        temp = Tabela[j + 1];
                        Tabela[j + 1] = Tabela[j];
                        Tabela[j] = temp;
                    }
                }
            }
            watch.Stop();
            return (float) watch.Elapsed.TotalMilliseconds;
        }
        public float UrediIzb()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            watch.Start();
            int temp, low;
            for(int i=0; i < Dolzina - 1; i++)
            {
                low = i;
                for(int j = i + 1; j < Dolzina; j++)
                {
                    if (Tabela[j] < Tabela[low]) low = j;
                }
                temp = Tabela[low];
                Tabela[low] = Tabela[i];
                Tabela[i] = temp;
            }
            watch.Stop();
            return (float) watch.Elapsed.TotalMilliseconds;
        }
        public void QuickSort(int start, int end)
        {
            if (start >= end)
            {
                return;
            }
            int num = Tabela[start];
            int i = start - 1;
            int j = end + 1;
            while (true)
            {
                do
                {
                    i++;
                } while (Tabela[i] < num);
                do
                {
                    j--;
                } while (Tabela[j] > num);
                if (i >= j)
                    break;
                if (i == j)
                    return;
                int temp = Tabela[i];
                Tabela[i] = Tabela[j];
                Tabela[j] = temp;
            }
            QuickSort(start, j);
            QuickSort(j + 1, end);
        }
        public void Napolni()
        {
            Random rand = new Random();
            for(int i=0; i <= 99; i++)
            {
                if (Tabela[i] == 0){
                    Tabela[i] = rand.Next(1, 1001);
                    Dolzina++;
                }
            }
        }
    }
}
