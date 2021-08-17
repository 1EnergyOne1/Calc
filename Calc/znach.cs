using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class znach: MainWindow
    {
        int z1 = 0;
        int z2 = 0;

        public void Text ()
        {
            int t1 = Convert.ToInt32(text1.Text);
            int t2 = Convert.ToInt32(text2.Text);
        }

        public void Znach(int znach1, int znach2)
        {
            z1 = znach1;
            z2 = znach2;
        }
    }
}
