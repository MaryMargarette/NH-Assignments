using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MargaretLibrary
{
    public class MyBaseClass
    {
        public int a;
        private int b;
        protected int c;
        internal int d;
        protected internal int e;


        public void ReadValue()
        {
            a = 10;
            b = 20;
            c = 30;
            d = 40;
            e = 50;

        }
    }

    
    class Derivedclass : MyBaseClass
    {
        public void ReadValue()
        {
            a = 10;
            b = 20;
            c = 30;
            d = 40;
            e = 50;

        }
    }

   class Otherclass
    {
        public void ReadValue()
        {
            MyBaseClass m = new MyBaseClass();
            m.a = 10;
            m.b = 20;
            m.c = 30;
            m.d = 40;
            m.e = 50;


        }
    }
}
