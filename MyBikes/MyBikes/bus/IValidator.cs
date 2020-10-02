﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBikes.bus
{
    interface IValidator
    {
        bool IsDigit(string text);
        bool IsAlphabetLetters(string text);
        bool IsLetterAndDigit(string text);

    }
}
