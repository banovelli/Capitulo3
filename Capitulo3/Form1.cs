﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capitulo3
{
    public partial class Form1 : Form
    {
        Guy joe;
        Guy bob;
        int bank = 100;

        public Form1()
        {
            InitializeComponent();

            joe = new Guy() { Cash = 15, Name = "Joe" };
            bob = new Guy() { Cash = 130, Name = "Bob" };
            UpdateForm();
        }

        public void UpdateForm()
        {
            joesCash.Text = joe.Name + " tem $" + joe.Cash;
            bobsCash.Text = bob.Name + " tem $" + bob.Cash;
            bankCash.Text = "O banco tem $" + bank;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(bank >= 10){
                bank -= joe.ReceiveCash(10);
                UpdateForm();
            }
            else{
                MessageBox.Show("O banco está sem dinehiro.");
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bank += bob.GiveCash(5);
            UpdateForm();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bob.ReceiveCash(joe.GiveCash(10));
            UpdateForm();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            joe.ReceiveCash(bob.GiveCash(5));
            UpdateForm();
        }
    }
}
