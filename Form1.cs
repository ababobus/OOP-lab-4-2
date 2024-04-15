using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Model model;
        public Form1()
        {
            InitializeComponent();
            model = new Model();

            model.observers += new System.EventHandler(this.UpdateFromModel);
        }


        private void UpdateFromModel(object sender, EventArgs e)
        {
            textbox_a.Text = model.GetValue('a').ToString();
            nud_a.Value = model.GetValue('a');
            trackbar_a.Value = model.GetValue('a');

            textbox_b.Text = model.GetValue('b').ToString();
            nud_b.Value = model.GetValue('b');
            trackbar_b.Value = model.GetValue('b');

            textbox_c.Text = model.GetValue('c').ToString();
            nud_c.Value = model.GetValue('c');
            trackbar_c.Value = model.GetValue('c');
        }


        public class Model
        {
            private int value_a;
            private int value_b;
            private int value_c;

            public System.EventHandler observers;
            public void SetValue(char symbol, int value)
            {
                if (value < 0)
                    value = 0;
                else if (value > 100)
                    value = 100;
                switch (symbol)
                {
                    case 'a':
                        value_a = value;
                        if (value_a > value_b)
                            value_b = value_a;
                        if (value_a > value_c)
                            value_c = value_a;
                        break;
                    case 'b':
                        value_b = value;
                        if (value_b < value_a)
                            value_b = value_a;
                        if (value_b > value_c)
                            value_b = value_c;
                        break;
                    case 'c':
                        value_c = value;
                        if (value_c < value_a)
                            value_a = value_c;
                        if (value_c < value_b)
                            value_b = value_c;
                        break;
                }
                observers.Invoke(this, null);
            }

            public int GetValue(char symbol)
            {
                switch (symbol)
                {
                    case 'a':
                        return value_a;
                    case 'b':
                        return value_b;
                    case 'c':
                        return value_c;
                }
                return -1;
            }
        }

        private void tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                if (sender == textbox_a)
                    model.SetValue('a', Convert.ToInt32(textbox_a.Text));
                else if (sender == textbox_b)
                    model.SetValue('b', Convert.ToInt32(textbox_b.Text));
                else if (sender == textbox_c)
                    model.SetValue('c', Convert.ToInt32(textbox_c.Text));
        }
        private void tb_TextChanged(object sender, EventArgs e)
        {
            if (sender == textbox_a)
                model.SetValue('a', Convert.ToInt32(textbox_a.Text));
            else if (sender == textbox_b)
                model.SetValue('b', Convert.ToInt32(textbox_b.Text));
            else if (sender == textbox_c)
                model.SetValue('c', Convert.ToInt32(textbox_c.Text));
        }

        private void nud_ValueChanged(object sender, EventArgs e)
        {
            if (sender == nud_a)
                model.SetValue('a', Convert.ToInt32(nud_a.Value));
            else if (sender == nud_b)
                model.SetValue('b', Convert.ToInt32(nud_b.Value));
            else if (sender == nud_c)
                model.SetValue('c', Convert.ToInt32(nud_c.Value));
        }
        private void trb_ValueChanged(object sender, EventArgs e)
        {
            if (sender == trackbar_a)
                model.SetValue('a', Convert.ToInt32(trackbar_a.Value));
            else if (sender == trackbar_b)
                model.SetValue('b', Convert.ToInt32(trackbar_b.Value));
            else if (sender == trackbar_c)
                model.SetValue('c', Convert.ToInt32(trackbar_c.Value));
        }
    }

}
