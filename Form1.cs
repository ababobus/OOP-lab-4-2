using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Model model;
        public Form1()
        {
            InitializeComponent();
            model = new Model();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nud_a_ValueChanged(object sender, EventArgs e)
        {
            //textbox_a. = Decimal.ToInt32(nud_a.Value);
            
        }
    }

    public class Model
    {
        private int value_a;
        private int value_b;
        private int value_c;
        public void SetValue(int value)
        {
            if (value < 0)
                value = 0;
            else if (value > 100)
                value = 100;

        }

        public int GetValue()
        {
            return value_a; ;
        }
    }
}
