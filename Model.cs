using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Model
    {
        private int a = 0;
        private int b = 0;
        private int c = 0;

        public EventHandler modelUpdated;
        int get_a() { return a; }
        int get_b() { return b; }
        int get_c() { return c; }

        void set_a(int value)
        {
            value = Math.Min(100, Math.Max(0, value));
            value = Math.Max(get_b(), value);
            a = value;
            modelUpdated?.Invoke(this, EventArgs.Empty);
        }
        void set_b(int value)
        {
            value = Math.Min(100, Math.Max(0, value));
            value = Math.Min(get_a(), Math.Max(get_c(), value));
            b = value;
            modelUpdated?.Invoke(this, EventArgs.Empty);
        }
        void set_c(int value)
        {
            value = Math.Min(100, Math.Max(0, value));
            value = Math.Min(get_b(), value);
            c = value;
            modelUpdated?.Invoke(this, EventArgs.Empty);
        }

    }
}
