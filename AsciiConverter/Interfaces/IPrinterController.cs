﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AsciiConverter.Interfaces
{
    interface IPrinterController
    {
        void PrintText(string txt, TextBox printBox, Form owner);
        void SetText(string text, TextBox targetBox);
        void SetText(int text, TextBox targetBox);
        void SetText(char text, TextBox targetBox);        
    }
}
