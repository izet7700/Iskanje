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
            Dolzina++;
            Tabela[Dolzina] = x;
        }
        public bool Vsebuje(int x)
        {
            bool vs = false;
            for (int i = 0; i <= Dolzina; i++)
            {
                if (x == Tabela[i])
                {
                    vs = true;
                    break;
                }
            }
            return vs;
        }
        public override string ToString()
        {
            string tab="";
            for (int i = 0; i <= Dolzina; i++)
            {
                tab = Tabela[i] + ", ";
            }
            return tab;
        }
        public int Vsota()
        {
            int vs = 0;
            for (int i = 0; i <= Dolzina; i++)
            {
                vs += Tabela[i];
            }
            return vs;
        }
        public int Min()
        {
            int min = Tabela[0];
            for (int i = 0; i <= Dolzina; i++)
            {
                if (Tabela[i] < min) min = Tabela[i];
            }
            return min;
        }
        public int Max()
        {
            int max = Tabela[0];
            for (int i = 0; i <= Dolzina; i++)
            {
                if (Tabela[i] > max) max = Tabela[i];
            }
            return max;
        }
        public double Povprecje()
        {
            return Vsota() / Dolzina;
        }
        public bool VsebujeBinarno(int x)
        {
            bool binVs = false;
            int min = 0, max = Dolzina;
            do
            {
                int mid = (min + max) / 2;
                if (x > Tabela[mid]) min = mid + 1;
                else if (x < Tabela[mid]) max = mid - 1;
                else if (x == Tabela[mid]) binVs = true;
            } while (min <= max);
            return binVs;
        }
    }
}
