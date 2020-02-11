using System;
using System.Collections.Generic;
using System.Text;

namespace CGS.Validations
{
    public class Validation
    {
        public static bool IsIdValid(string ID)
        {
            bool condition = true;
            if (ID.Length != 5)
                return false;

            foreach (var character in ID)
            {
                if (!Char.IsNumber(character))
                {
                    condition = false;
                    break;
                }
            }

            return condition;
        }

        public static bool IsAtMost40Char(string text)
        {
            if (text.Length > 40)
                return false;

            return true;
        }
    }
}
