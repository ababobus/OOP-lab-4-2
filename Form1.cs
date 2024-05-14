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
using static System.Net.Mime.MediaTypeNames;
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

            model.dataChanged += new System.EventHandler(this.UpdateFromModel);
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            model.save();
        }

        private void UpdateFromModel(object sender, EventArgs e)
        {
            textbox_a.Text = model.get_a().ToString();
            nud_a.Value = model.get_a();
            trackbar_a.Value = model.get_a();

            textbox_b.Text = model.get_b().ToString();
            nud_b.Value = model.get_b();
            trackbar_b.Value = model.get_b();

            textbox_c.Text = model.get_c().ToString();
            nud_c.Value = model.get_c();
            trackbar_c.Value = model.get_c();
        }

        private void tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (sender == textbox_a)
                    model.set_a(textbox_a.Text);
                else if (sender == textbox_b)
                    model.set_b(textbox_b.Text);
                else if (sender == textbox_c)
                    model.set_c(textbox_c.Text);
            }

        }
        private void trb_ValueChanged(object sender, EventArgs e)
        {
            if (sender == trackbar_a)
                model.set_a(trackbar_a.Value.ToString()); 
            else if (sender == trackbar_b)
                model.set_b(trackbar_b.Value.ToString());
            else if (sender == trackbar_c)
                model.set_c(trackbar_c.Value.ToString());
        }

        private void nud_ValueChanged(object sender, EventArgs e)
        {
            if (sender == nud_a)
                model.set_a(nud_a.Value.ToString());
            else if (sender == nud_b)
                model.set_b(nud_b.Value.ToString());
            else if (sender == nud_c)
                model.set_c(nud_c.Value.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            model.load();
        }

        private void textbox_b_MouseDown(object sender, MouseEventArgs e)
        {
            UpdateFromModel(sender, e);
        }
    }
}
