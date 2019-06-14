using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First
{
    public partial class First_Form : Form
    {
        public First_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] arma = null;
            string PT = null, CT = null;
            int i = 0, key, flag = 0, temp;
            i = 0;
            flag = 0;
            PT = tb1.Text;
            bool check = PT.Contains(" ");
            if (check == true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                MessageBox.Show("\n Special Charaters or digits not allowed in ceaser cypher encryption");
                goto there;
            }
            arma = PT.ToCharArray();
            foreach (char c in arma)
            {
                if (!Char.IsLetter(c)) //(!Char.IsLetterOrDigit(c) && c!='_')
                    flag = 1;
            }
            if (flag == 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                MessageBox.Show("\n Special Charaters or digits not allowed in ceaser cypher encryption");
                goto there;
            }
            key = int.Parse(tb2.Text);
            if (key > 26)
                key = key % 26;
            for (i = 0; i < arma.Length; i++)
            {
                if (arma[i] >= 65 & arma[i] <= 90)
                {
                    temp = (int)(arma[i] + key);
                    if (temp > 90)
                        temp = temp - 26;
                    CT += (char)(temp);
                }
                if (arma[i] >= 97 & arma[i] <= 122)
                {
                    temp = (int)(arma[i] + key);
                    if (temp > 122)
                        temp = temp - 26;
                    CT += (char)(temp);
                }
            }
            //MessageBox.Show(" The Cipher Text is : " + CT);
            tb3.Text = CT;
            there:
            ;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void First_Form_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void filieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (closeToolStripMenuItem.Enabled)
                MessageBox.Show("Hey You Learned");
                
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);

        }
    }
}
