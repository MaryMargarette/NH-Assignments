using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarryLibrary
{
    public class Physics
    {
        public int FinalVelocity(int u,int a,int t)
        {
            return u+a*t;
        }
        public int Force(int m,int a)
        {
            return m*a;
        }
    }
}
