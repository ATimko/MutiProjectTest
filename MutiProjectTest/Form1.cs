﻿using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using BusinessLogic.Validation;

namespace MutiProjectTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string test = "555-55-5255";
            if (Validator.IsSsn(test))
            {
                MessageBox.Show("All Good");
            }
            return;

            Student stu = new Student();
            SpeechSynthesizer speech = new SpeechSynthesizer();
            speech.Speak("Student was created!");
        }
    }
}
