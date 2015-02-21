using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1

{
    public partial class Form1 : Form
    {
        int blife = 10, maxblife=10, melife = 1000, bdamage = 10, exp = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((progressBar1.Value > 0) && (progressBar2.Value > 0))
            {
                Random rn = new Random();
                int damage = 50 + rn.Next(-10, 10);
                if (rn.Next(0, 100) <= 15)

                {
                    damage = 50;
                }
                label1.Text = damage.ToString();
                blife -= damage;
                if (blife -damage<= 0)
                {

                    exp += 25;
                    if (exp >= 100) 
                        exp -= 100;
                    label7.Text = (Int32.Parse(label7.Text) + 1).ToString();
                    progressBar3.Value = exp;

                    progressBar2.Maximum = maxblife;                  
                    progressBar2.Value = maxblife;
                   
                    
                    //pictureBox1.ImageLocation= "boss2.jpg";
                    //pictureBox1.Load();
                    maxblife += 250;
                    blife = maxblife;

                    listBox1.Items.Add(listBox2.Items[rn.Next(0,listBox2.Items.Count)]);
                    
                }
                else
                {
                    progressBar2.Value = 10;
                }
                //System.Threading.Thread.Sleep(500);//Нас ударяют
                bdamage = 10 + rn.Next(-5, 5);
                if (rn.Next(0, 100) <= 10)
                {
                    bdamage = 10;
                }
                label1.Text = bdamage.ToString();
                melife -= bdamage;
                if (melife -bdamage<= 0)
                {
                    progressBar1.Value = 0;
                    pictureBox2.Visible = false;

                    return;
                }
                else
                {
                    progressBar1.Value = melife;
                }
            }   
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
               
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
                    label1.Text = listBox1.SelectedItem.ToString();
            if (listBox1.SelectedItem == "еда") 
            {

                listBox1.Items.RemoveAt (listBox1.SelectedIndex);
                melife += 1000;
                if (progressBar1.Value + 1000 > progressBar1.Maximum) progressBar1.Value = progressBar1.Maximum;
                else
                    progressBar1.Value = 1000;
            
            }
            }

        private void progressBar3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        }
    }

