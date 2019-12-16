using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste1212
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private int[] sorteia(int qtd, int max)
        {
            Random rnd = new Random();
            List<int> lista = new List<int>();
            for (int i = 0; i < qtd; i++)
            {
                int tmp;
                do tmp = rnd.Next(1, max + 1);
                while (lista.Contains(tmp));
                lista.Add(tmp);
            }
            lista.Sort();
            return lista.ToArray();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            int[] n = sorteia(5, 50);
            int[] s = sorteia(2, 12);
            n1.Text = n[0].ToString();
            n2.Text = n[1].ToString();
            n3.Text = n[2].ToString();
            n4.Text = n[3].ToString();
            n5.Text = n[4].ToString();
            e1.Text = s[0].ToString();
            e2.Text = s[1].ToString();
        }
    }
}