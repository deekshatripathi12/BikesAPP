using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBikes.bus
{
    interface ICheckErrorProvider
    {
        void IsDigitCheck(ErrorProvider obj1, TextBox obj2);
        void IsLetterCheck(ErrorProvider obj1, TextBox obj2);
        void IsLetterAndDigitCheck(ErrorProvider obj1, TextBox obj2);
    }
}
