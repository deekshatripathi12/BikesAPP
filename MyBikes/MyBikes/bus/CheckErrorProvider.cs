using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBikes.bus
{
    class CheckErrorProvider : ICheckErrorProvider
    {
        public void IsDigitCheck(ErrorProvider obj1, TextBox obj2)
        {
            IValidator validator = new Validator();
            if (!(validator.IsDigit(obj2.Text)))
            {
                //MessageBox.Show("Digit only--from Validator class");
                obj1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                obj2.Clear();
                obj2.Focus();
            }
            else
            {
                obj1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            }
        }
        public void IsLetterCheck(ErrorProvider obj1, TextBox obj2)
        {
            IValidator validator = new Validator();
            if (!(validator.IsAlphabetLetters(obj2.Text)))
            {
                //MessageBox.Show("Digit only--from Validator class");
                obj1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                obj2.Clear();
                obj2.Focus();
            }
            else
            {
                obj1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            }
        }
        public void IsLetterAndDigitCheck(ErrorProvider obj1, TextBox obj2)
        {
            IValidator validator = new Validator();
            if (!(validator.IsLetterAndDigit(obj2.Text)))
            {
                //MessageBox.Show("Digit only--from Validator class");
                obj1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                obj2.Clear();
                obj2.Focus();
            }
            else
            {
                obj1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            }
        }
    }
}
