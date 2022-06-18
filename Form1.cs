using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pelinöztask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int boyut;
        public string[] ilkdizi;
        public int[] dizi;
        public int oncekiindis;
        public object Oyna(int indis)
        {
            int deger = dizi[indis];
            if ((0 <= deger) && (deger < boyut))
            {
                if (oncekiindis == deger)
                {
                    return -1;
                }
                oncekiindis = indis;
                MessageBox.Show("Döngüye girdi!");
                return -1;
            }
            else
            {
                MessageBox.Show("Negatif veya boyutu aşan bir değer girdiniz.");
                return -1;
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            ilkdizi = textBox1.Text.Split(',');
            boyut = ilkdizi.Length;
            dizi = new int[boyut];
            for(int i = 0; i < boyut; i++)
            {
                dizi[i] = Convert.ToInt32(ilkdizi[i]);
            }
            oncekiindis = 0;
            int indis = 0;
            int hitcount = 0;
            while (indis != -1)
            {
                hitcount++;
                indis = Convert.ToInt32(Oyna(indis));
            }
            label2.Text = "HİT COUNT=" + hitcount.ToString();
            
            
        }
    }
}
