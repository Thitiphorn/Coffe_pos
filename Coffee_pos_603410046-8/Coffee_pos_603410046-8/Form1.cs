using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_pos_603410046_8
{
    public partial class Form1 : Form
    {
        string N_t = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Coffee_nu("Esspresso(Hot)", "35");
        }
        public void Coffee_nu (string menu,string bath)
        {
            string[] nn = { menu, bath };
            var l_v = new ListViewItem(nn);
            lv.Items.Add(l_v);
           NN();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Coffee_nu("Esspresso(Ice)", "45");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Coffee_nu("Esspresso(Frappe)", "50");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Coffee_nu("Americano(Hot)", "35");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Coffee_nu("Americano(Ice)", "45");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Coffee_nu("Americano(Frappe)", "50");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Coffee_nu("Latte(Hot)", "35");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Coffee_nu("Latte(Ice)", "45");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Coffee_nu("Latte(Frappe)", "50");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Coffee_nu("Mocha(Hot)", "35");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Coffee_nu("Mocha(Ice)", "45");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Coffee_nu("Mocha(Frappe)", "50");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Coffee_nu("Cappuccino(Hot)", "35");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Coffee_nu("Cappuccino(Ice)", "45");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Coffee_nu("Cappuccino(Frappe)", "50");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Coffee_nu("Green Tae(Hot)", "20");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Coffee_nu("Green Tae(Ice)", "25");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Coffee_nu("Green Tae(Frappe)", "30");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Coffee_nu("Thai Tae(Hot)", "20");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Coffee_nu("Thai Tae(Ice)", "25");
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Coffee_nu("Thai Tae(Frappe)", "30");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Coffee_nu("Co Coa(Hot)", "20");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Coffee_nu("Co Coa(Ice)", "25");
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Coffee_nu("Co Coa(Frappe)", "30");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Coffee_nu("Milk(Hot)", "20");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Coffee_nu("Milk(Ice)", "25");
        }

        private void button31_Click(object sender, EventArgs e)
        {
            Coffee_nu("Milk(Frappe)", "30");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Coffee_nu("Milk Tea(Hot)", "20");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Coffee_nu("Milk Tea(Ice)", "25");
        }

        private void button32_Click(object sender, EventArgs e)
        {
            Coffee_nu("Milk Tea(Frappe)", "30");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Coffee_nu("green Tea(Hot)", "20");
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Coffee_nu("green Tea(Ice)", "25");
        }

        private void button33_Click(object sender, EventArgs e)
        {
            Coffee_nu("green Tea(Frappe)", "30");
        }

        private void button34_Click(object sender, EventArgs e)
        {
            Coffee_nu("Milo(Hot)", "20");
        }

        private void button37_Click(object sender, EventArgs e)
        {
            Coffee_nu("Milo(Ice)", "25");
        }

        private void button40_Click(object sender, EventArgs e)
        {
            Coffee_nu("Milo(Frappe)", "30");
        }

        private void button35_Click(object sender, EventArgs e)
        {
            Coffee_nu("Nescafe(Hot)", "20");
        }

        private void button38_Click(object sender, EventArgs e)
        {
            Coffee_nu("Nescafe(Ice)", "25");
        }

        private void button41_Click(object sender, EventArgs e)
        {
            Coffee_nu("Nescafe(Frappe)", "30");
        }

        private void button36_Click(object sender, EventArgs e)
        {
            Coffee_nu("Nestea Tea(Hot)", "20");
        }

        private void button39_Click(object sender, EventArgs e)
        {
            Coffee_nu("Nestea Tea(Ice)", "25");
        }

        private void button42_Click(object sender, EventArgs e)
        {
            Coffee_nu("Nestea Tea(Frappe)", "30");
        }

        private void button43_Click(object sender, EventArgs e)
        {
            Coffee_nu("Cataloupe(Ice)", "25");
        }

        private void button44_Click(object sender, EventArgs e)
        {
            Coffee_nu("Blue Hawai(Ice)", "25");
        }

        private void button45_Click(object sender, EventArgs e)
        {
            Coffee_nu("Stawbery(Ice)", "25");
        }

        private void button46_Click(object sender, EventArgs e)
        {
            Coffee_nu("Red Lime Soda(Ice)", "25");
        }

        private void button47_Click(object sender, EventArgs e)
        {
            Coffee_nu("Apple(Ice)", "25");
        }

        private void button48_Click(object sender, EventArgs e)
        {
            Coffee_nu("Honey Lime Soda(Ice)", "25");
        }

        double Nut;
        public string[] NN()
        {
            Nut = 0;
            string[] jj = new string[lv.Items.Count];
            int j = lv.Items.Count;
            for (int i = 0; i < j; i++)
            {
                Nut += double.Parse(lv.Items[i].SubItems[1].Text);
                jj[i] = lv.Items[i].SubItems[0].Text.ToString();
            }
            label39.Text = Nut.ToString();
            return jj;
        }
        public string[]TT()
        {
            string[] jj = new string[lv.Items.Count];
            int j = lv.Items.Count;
            for (int i=0; i < j;i++)
            {
                jj[i] = lv.Items[i].SubItems[1].Text.ToString();
            }
            return jj;
        }

        public void T_P()
        {
            string[] nt = NN();
            
            string[] PS = TT();
            string file = "NUT_Coffee" + DateTime.Now.ToString("hhmmss_dd_mm_yy");
            string bill = "NUT_Coffe";
            bill += "\r\n" + DateTime.Now.ToString("hh:mm:ss") + "\r\n" + DateTime.Now.ToString("dd//mm//yyy");
            bill += "Menu" + "\r\n";
            for (int i =0; i < lv.Items.Count;i++)
            {
                bill += nt[i] + new string(' ', 20) + PS[i] + "Bath" + "\r\n";
              
            }
            bill += "\r\n";
            bill += "Total Price : " + label39.Text;
            System.IO.File.WriteAllText(N_t + @"\" + file + "txt", bill);
            textBox1.Text += bill + "\r\n" + "\r\n" + "\r\n" + "Save File at" + N_t + @"\" + file + ".txt";

        }  
        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.Controls.Remove(Payment);
        }

        private void button50_Click(object sender, EventArgs e)
        {
            lv.Items.Clear();
            nn_jj = false;
            tabControl1.Controls.Remove(Payment);
            label39.Text = "";
        }
        bool nn_jj = false;
        private void button49_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            if (nn_jj == false)
            {
                tabControl1.TabPages.Insert(1, Payment);
                nn_jj = true;
                tabControl1.SelectedTab = Payment;
            }
            else tabControl1.SelectedTab = Payment;
            if (lv.Items.Count > 0)
                T_P();
                
                    
                }

        private void Payment_Click(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }
    }
        }
    
    
    
    

