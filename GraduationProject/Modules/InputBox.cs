

namespace GraduationProject
{
    public class InputBox
    {
        public struct InputboxResponce
        {
            public string text;
            public bool canceled;
        }
        public static InputboxResponce OpenInputBox(string labelText)
        {
            InputboxResponce inputboxResponce = new InputboxResponce();
            Forms.InputBoxForm inputBoxForm = new Forms.InputBoxForm(labelText);
            inputBoxForm.ShowDialog();
            inputboxResponce.text = inputBoxForm.text;
            inputboxResponce.canceled = inputBoxForm.canceled;
            return inputboxResponce;
        }

    }
}
