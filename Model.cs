using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;
using System.Reflection;

namespace WindowsFormsApp1
{
    internal class Model
    {
        private int a = 0;
        private int b = 0;
        private int c = 0;

        public EventHandler dataChanged;
        public int get_a() { return a; }
        public int get_b() { return b; }
        public int get_c() { return c; }

        public void set_a(string value)
        {
            if (int.TryParse(value, out int number))
            {
                a = Math.Min(100, Math.Max(0, number));
                b = Math.Max(a, b);
                c = Math.Max(a, c);
            }


            dataChanged.Invoke(this, EventArgs.Empty);
        }

        public void set_b(string value)
        {
            if (int.TryParse(value, out int number))
            {
                number = Math.Min(100, Math.Max(0, number));
                number = Math.Max(get_a(), Math.Min(get_c(), number));
                b = number;
            }

            dataChanged.Invoke(this, EventArgs.Empty);
        }

        public void set_c(string value)
        {
            if (int.TryParse(value, out int number))
            {
                c = Math.Min(100, Math.Max(0, number));
                b = Math.Min(c, b);
                a = Math.Min(c, a);
            }
            dataChanged.Invoke(this, EventArgs.Empty);
        }
        public void save()
        {

            Properties.Settings.Default.SettingA = get_a();
            Properties.Settings.Default.SettingB = get_b();
            Properties.Settings.Default.SettingC = get_c();
            Properties.Settings.Default.Save();
            dataChanged.Invoke(this, EventArgs.Empty);
        }
        public void load()
        {

            set_c(Properties.Settings.Default.SettingC.ToString());
            set_b(Properties.Settings.Default.SettingB.ToString());
            set_a(Properties.Settings.Default.SettingA.ToString());
            dataChanged.Invoke(this, EventArgs.Empty);
        }
    }
}
