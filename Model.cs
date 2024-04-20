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

        public EventHandler observers;
        public int get_a() { return a; }
        public int get_b() { return b; }
        public int get_c() { return c; }

        public void set_a(int value)
        {
            a = Math.Min(100, Math.Max(0, value));
            b = Math.Max(a, b);
            c = Math.Max(a, c);
            
            observers?.Invoke(this, EventArgs.Empty);
        } 

        /*public void set_a(int value)
        {
            try
            {
                if (value < 0) { a = 0; }
                else
                {
                    if (value > 100) { a = 100; }
                    else { a = value; }
                    if (a > b)
                    {
                        b = a;
                        if (b > c) { c = b; }
                    }
                }
            }
            finally
            {
                observers?.Invoke(this, EventArgs.Empty);
            }

        }*/


        /*public void set_a(int value)
        {
            if (value < 0) { a = 0; }
            else
            {
                if (value > 100){ a = 100;}
                else { a = value;}
                if (a > b)
                {
                    b = a;
                    if (b > c) {c = b;}
                }
            }
            observers?.Invoke(this, EventArgs.Empty);
        }

        */public void set_b(int value)
        {
            
            value = Math.Min(100, Math.Max(0, value));
            value = Math.Max(get_a(), Math.Min(get_c(), value));
            b = value;
            observers?.Invoke(this, EventArgs.Empty);
        }

        /*public void set_c(int value)
        {
            if (value < 0) { c = 0; }
            else
            {
                if (value > 100) { c = 100; }
                else { c = value; }
                if (c< b)
                {
                    b = c;
                    if (b < a) { a = b; }
                }
            }
        }*/
        public void set_c(int value)
        {
            c = Math.Min(100, Math.Max(0, value));
            b = Math.Min(c, b);
            a = Math.Min(c, a);
            observers?.Invoke(this, EventArgs.Empty);
        }
    }
}
