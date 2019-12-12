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

        private void Button1_Click(object sender, EventArgs e)
        {
            List<int> n = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < 5;i++)
            {
                {
                    int tmp;
                    do tmp = rnd.Next(1, 51);
                    while (s.Contains(tmp));
                }
                s.Add(tmp);
            }
            n1.Text = n[0].ToString();
            n2.Text = n[1].ToString();
            n3.Text = n[2].ToString();
            n4.Text = n[3].ToString();
            n5.Text = n[4].ToString();

            int[] s = new int[2];
            for (int i = 0; i < 2; i++)
            {
                bool existe;
                do
                {
                    Random rnd = new Random();
                    n[i] = rnd.Next(1, 13);
                    existe = false;
                    for (int j = 0; j < i; j++)
                        if (n[i] == n[j]) existe = true;
                }
                while (existe);
            }
            e1.Text = n[0].ToString();
            e2.Text = n[1].ToString();
        }

    }
}