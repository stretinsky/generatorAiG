using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using GenaratorAiG.Tasks.Complex;

namespace GenaratorAiG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Task_26 task25 = new Task_26();
            MessageBox.Show($"{task25.GetCondition()}\n{ task25.GetAnswer()}");
            
        }
    }
}
