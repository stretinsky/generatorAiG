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
            Task_13546 task = new Task_13546();
            MessageBox.Show(task.GetCondition() + "\n" + task.GetAnswer());
        }
    }
}
