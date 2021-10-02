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

namespace Cod_de_bare
{
    class Numere
    {
        double b1;//bara1
        double b2;//bara2
        double b3;//bara3
        double b4;//bara4
        double b5;//bara5
        public Numere(double B1, double B2, double B3, double B4, double B5)
        {
            this.b1 = B1;
            this.b2 = B2;
            this.b3 = B3;
            this.b4 = B4;
            this.b5 = B5;
        }
        public double B1
        {
            get { return b1; }
            set { this.b1 = value; }
        }
        public double B2
        {
            get { return b2; }
            set { this.b2 = value; }
        }
        public double B3
        {
            get { return b3; }
            set { this.b3 = value; }
        }
        public double B4
        {
            get { return b4; }
            set { this.b4 = value; }
        }
        public double B5
        {
            get { return b5; }
            set { this.b5 = value; }
        }
        
        public static void deseneaza(Graphics g,Numere a,int x)
        {
            int alternare_culori;
            SolidBrush b;
            if ((x  / 29) % 2 == 0)
            {
                b = new SolidBrush(Color.Black);
                alternare_culori = 0;
            }
            else
            {
                b= new SolidBrush(Color.White);
                alternare_culori = 1;
            }
            g.FillRectangle(b, x, 5, (int)a.b1, 90);
            alternare_culori++;
            b = new SolidBrush(alternare_culori % 2 == 1 ? Color.White : Color.Black);
            x += (int)a.b1;
            g.FillRectangle(b, x, 5, (int)a.b2, 90);
            alternare_culori++;
            b = new SolidBrush(alternare_culori % 2 == 1 ? Color.White : Color.Black);
            x += (int)a.b2;
            g.FillRectangle(b, x, 5, (int)a.b3, 90);
            alternare_culori++;
            b = new SolidBrush(alternare_culori % 2 == 1 ? Color.White : Color.Black);
            x += (int)a.b3;
            g.FillRectangle(b, x, 5, (int)a.b4, 90);
            alternare_culori++;
            b = new SolidBrush(alternare_culori % 2 == 1 ? Color.White : Color.Black);
            x += (int)a.b4;
            g.FillRectangle(b, x, 5, (int)a.b5, 90);
            alternare_culori++;
            b = new SolidBrush(alternare_culori % 2 == 1 ? Color.White : Color.Black);
            x += (int)a.b5;
        }
        public static void deseneaza_negativ(Graphics g, Numere a, int x)
        {
            int alternare_culori;
            SolidBrush b;
            if ((x / 29) % 2 == 0)
            {
                b = new SolidBrush(Color.White);
                alternare_culori = 0;
            }
            else
            {
                b = new SolidBrush(Color.Black);
                alternare_culori = 1;
            }
            g.FillRectangle(b, x, 5, (int)a.b1, 90);
            alternare_culori++;
            b = new SolidBrush(alternare_culori % 2 == 1 ? Color.Black : Color.White);
            x += (int)a.b1;
            g.FillRectangle(b, x, 5, (int)a.b2, 90);
            alternare_culori++;
            b = new SolidBrush(alternare_culori % 2 == 1 ? Color.Black : Color.White);
            x += (int)a.b2;
            g.FillRectangle(b, x, 5, (int)a.b3, 90);
            alternare_culori++;
            b = new SolidBrush(alternare_culori % 2 == 1 ? Color.Black : Color.White);
            x += (int)a.b3;
            g.FillRectangle(b, x, 5, (int)a.b4, 90);
            alternare_culori++;
            b = new SolidBrush(alternare_culori % 2 == 1 ? Color.Black : Color.White);
            x += (int)a.b4;
            g.FillRectangle(b, x, 5, (int)a.b5, 90);
            alternare_culori++;
            b = new SolidBrush(alternare_culori % 2 == 1 ? Color.Black : Color.White);
            x += (int)a.b5;
        }
    }
}
