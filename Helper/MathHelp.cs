using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace e_Learning.Helper
{
    public class MathHelp
    {
        public int TinhGiaiThua(int a)
        {
            int giaithua = 1;
            for (int i = 1; i <= a; i++)
            {
                giaithua = giaithua * i;
            }
            return giaithua;
        }
    }
}