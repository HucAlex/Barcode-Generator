using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.IO;
using System.Drawing.Imaging;
namespace Cod_de_bare
{
    public partial class Form1 : Form
    {
        double l = 5;//bara ingusta
        double L = 7;//bara lata
        List<Numere> Numar;//numar
        Graphics g;
        Bitmap DrawArea;
        int c = 0;
        
        public Form1()
        {
            // Facem Bitmap
            InitializeComponent();
            DrawArea = new Bitmap(pictureBox1.Size.Width, pictureBox1.Size.Height);
            pictureBox1.Image = DrawArea;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Numar = new List<Numere>();
            Numar.Add(new Numere(l, l, L, L, l)); //0
            Numar.Add(new Numere(L, l, l, l, L)); //1
            Numar.Add(new Numere(l, L, l, l, L)); //2
            Numar.Add(new Numere(L, L, l, l, l)); //3
            Numar.Add(new Numere(l, l, L, l, L)); //4
            Numar.Add(new Numere(L, l, L, l, l)); //5
            Numar.Add(new Numere(l, L, L, l, l)); //6
            Numar.Add(new Numere(l, l, l, L, L)); //7
            Numar.Add(new Numere(L, l, l, L, l)); //8
            Numar.Add(new Numere(l, L, l, L, l)); //9
        }

        private void generare_Click(object sender, EventArgs e)
        {
            String text = valoare.Text;
            g = Graphics.FromImage(DrawArea);//noua imagine din cea existenta
            g.Clear(Color.White);//fundal nou
            int sum_par = 0;
            int sum_impar = 0;
            if (text.Length % 2 == 0) //verifica daca are nr par
            {
                Numere.deseneaza(g, Numar[0], DrawArea.Width / 2 - 29 * (text.Length / 2));//desenare 0
                for (int i = 0; i < text.Length; i++)
                {
                    Numere.deseneaza(g, Numar[Int32.Parse(text[i].ToString())],DrawArea.Width / 2 - 29 * (text.Length / 2) + i * 29);//desenare i
                    if (i % 2 == 0)
                        sum_impar += text[i] - '0';
                    else
                        sum_par += text[i] - '0';
                }
                c = 10 - ((sum_impar + 3 * sum_par) % 10);
                Numere.deseneaza(g, Numar[c], DrawArea.Width / 2 + (text.Length / 2) *  29);//deseneaza cheia
                pictureBox1.Invalidate();//redeseneaza
            }
            else
                MessageBox.Show("Introdu numar par de cifre!");
        }

        private void salvare_Click(object sender, EventArgs e)
        {
            // se salveaza codul de bare
            pictureBox1.Image.Save("Cod_de_bare_" + valoare.Text.ToString() + ".Jpeg",System.Drawing.Imaging.ImageFormat.Jpeg);
            MessageBox.Show("Salvat!");
        }

        private void valoare_KeyDown(object sender, KeyEventArgs e)
        {   //butonul reactioneaza si la Enter
            if (e.KeyCode == Keys.Enter)
            {
                generare.PerformClick();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // se adauga bordura sau nu
            if (checkBox1.Checked)
            {
                pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            }
            else
            {
                pictureBox1.BorderStyle = BorderStyle.None;
            }    
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            // se afiseaza textul
            if (checkBox2.Checked)
            {
                val.Text = '0' + valoare.Text + c;
                val.Invalidate();
                pictureBox1.Invalidate();
            }
            else
                val.Text = "";
            pictureBox1.Invalidate();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {   //negativ
            String text;
            text = valoare.Text;
            g = Graphics.FromImage(DrawArea);
            int sum_par = 0, sum_impar = 0;
            if (checkBox3.Checked)
            {
                if (text.Length % 2 == 0)
                {
                    Numere.deseneaza_negativ(g, Numar[0], DrawArea.Width / 2 - 29 * (text.Length / 2) - 29);
                    for (int i = 0; i < text.Length; i++)
                    {
                        Numere.deseneaza_negativ(g,
                       Numar[Int32.Parse(text[i].ToString())], DrawArea.Width / 2 - 29 * (text.Length / 2) + i * 29);
                        if (i % 2 == 0)
                            sum_impar += text[i] - '0';
                        else
                            sum_par += text[i] - '0';
                    }
                    c = 10 - ((sum_impar + 3 * sum_par) % 10);
                    Numere.deseneaza_negativ(g, Numar[c], DrawArea.Width / 2 +
                   (text.Length / 2) * 29);
                    pictureBox1.Invalidate();
                }
                else
                    MessageBox.Show("Introdu numar par de cifre!");
            }
            else
            {
                if (text.Length % 2 == 0)
                {
                    Numere.deseneaza(g, Numar[0], DrawArea.Width / 2 - 29 * (text.Length/ 2) - 29);
                    for (int i = 0; i < text.Length; i++)
                    {
                        Numere.deseneaza(g, Numar[Int32.Parse(text[i].ToString())],
                       DrawArea.Width / 2 - 29 * (text.Length / 2) + i * 29);
                        if (i % 2 == 0)
                            sum_impar += text[i] - '0';
                        else
                            sum_par += text[i] - '0';
                    }
                    c = 10 - ((sum_impar + 3 * sum_par) % 10);
                    Numere.deseneaza(g, Numar[c], DrawArea.Width / 2 + (text.Length / 2)
                   * 29);
                    pictureBox1.Invalidate();
                }
                else
                    MessageBox.Show("Introdu numar par de cifre!");
            }
            pictureBox1.Invalidate();
        }
    }
}
    

