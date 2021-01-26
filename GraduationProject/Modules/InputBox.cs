using System;
using System.Collections.Generic;
using System.Text;

namespace GraduationProject
{
    public class InputBox
    {
        public static string OpenInputBox()
        {
            string text;
            Forms.InputBoxForm inputBoxForm = new Forms.InputBoxForm();
            inputBoxForm.ShowDialog();
            text = inputBoxForm.text;
            return text;
        }

    }
}
