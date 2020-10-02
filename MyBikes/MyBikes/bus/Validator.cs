using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.RegularExpressions;

namespace MyBikes.bus
{
    class Validator : IValidator
    {
        /*********   -1- 
        * IsAlphabetLetters(string param1)
        * ^([a-zA-Z|\s]+)$
        * ^ represents begining
        * $ represents ending
        * a-zA-Z represents alphabet letters 
        * \s is for adding space
        * + sign represents that we can have more than one space and more than one alphabet
        *********************/
        public bool IsDigit(string text)
        {
            Regex number = new Regex(@"^([1-9]+)$");
            return number.IsMatch(text);
        }
        public bool IsAlphabetLetters(string text)
        {
            Regex name = new Regex(@"^([a-zA-Z|\s]+)$");
            return name.IsMatch(text);
        }
        public bool IsLetterAndDigit(string text)
        {
            Regex name = new Regex(@"^([A-Za-z0-9]+)$");
            return name.IsMatch(text);
        }
    }
}
