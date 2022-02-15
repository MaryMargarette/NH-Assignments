using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MargaretLibrary;

namespace MarLibrary
{
    public class Derived : MyBaseClass
    {
        public void Write()
        {
            a = 10;
            b = 20;
            c = 30;
            d = 40;
            e = 50;
        }
    }
    public class Otherclass
    {
        public void Write()
        {
            MyBaseClass m = new MyBaseClass();
            m.a = 1;
            m.b = 2;
            m.c = 3;
            m.d = 4;
            m.e = 5;
        }
        

    }
}
