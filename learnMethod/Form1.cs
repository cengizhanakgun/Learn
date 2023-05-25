using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace learnMethod
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

        void RastgeleSayiOlustur()
        {
            Random rnd = new Random();
            int rastgeleSayi = rnd.Next(1, 201);
            MessageBox.Show(rastgeleSayi.ToString());
        }
        void EmailAdressCreate(string companyName)
        {
            string name = textBox1.Text;   
            string lastName = textBox2.Text;

            string emailAdress = $"{name}.{lastName}@{companyName}.com";
            MessageBox.Show("Your new Email created",emailAdress);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmailAdressCreate("astamedica");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmailAdressCreate("gmail");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmailAdressCreate("dsmile");
        }
    }
}
