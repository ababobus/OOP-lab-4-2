using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace WindowsFormsApp1
{
    internal class Model
    {
        private int a = 0;
        private int b = 0;
        private int c = 0;

        public EventHandler observers;
        public int get_a() { return a; }
        public int get_b() { return b; }
        public int get_c() { return c; }

        public void set_a(int value)
        {
            a = Math.Min(100, Math.Max(0, value));
            b = Math.Max(a, b);
            c = Math.Max(a, c);

            Properties.Settings.Default.SettingA= a ;
            Properties.Settings.Default.Save();

            observers?.Invoke(this, EventArgs.Empty);
        } 

        public void set_b(int value)
        {
            
            value = Math.Min(100, Math.Max(0, value));
            value = Math.Max(get_a(), Math.Min(get_c(), value));
            b = value;
            Properties.Settings.Default.Save();
            observers?.Invoke(this, EventArgs.Empty);
        }

        public void set_c(int value)
        {
            c = Math.Min(100, Math.Max(0, value));
            b = Math.Min(c, b);
            a = Math.Min(c, a);
            Properties.Settings.Default.Save();
            observers?.Invoke(this, EventArgs.Empty);
        }
    }
}
