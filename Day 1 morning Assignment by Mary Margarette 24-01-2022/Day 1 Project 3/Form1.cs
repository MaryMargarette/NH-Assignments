﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day_1_Project_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int fn, sn, sum = 0;

            Console.WriteLine("enter number");
            fn = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter number");
            sn = Convert.ToInt32(Console.ReadLine());

            sum = fn + sn;

            Console.WriteLine("sum =" + sum);
            Console.ReadLine();
        }
    }
}
