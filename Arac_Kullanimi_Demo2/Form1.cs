﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arac_Kullanimi_Demo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rota : "+comboBox1.Text + " ->" + comboBox2.Text + " - "+" Tarih : " + dateTimePicker1.Text + " - " + "Saat:" + maskedTextBox1.Text + "Yolcu Bilgileri ~ Ad :" + textBox1.Text + "  TC" + maskedTextBox2.Text + "Telefon :  " + maskedTextBox3.Text);
            MessageBox.Show("Yolcu Kaydı Yapıldı");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string temp;
            temp = comboBox1.Text;
            comboBox1.Text = comboBox2.Text;
            comboBox2.Text = temp;

        }
    }
}
