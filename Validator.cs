using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13
{
    class Validator
    {
        //verify that the user's input is not blank
        public static bool ValidateStringNotNull(string input)
        {
            if (input == "")
            { return false; }
            else
            { return true; }
        }
        //verify that the user's input matches one of the valid options
        public static bool ValidateIsOption(string input, string validOptions)
        {
            string[] validArray = validOptions.Split('/');
                foreach(string option in validArray)
            {
                if (input.ToLower() == option.ToLower()||option.ToLower() == "any")
                {
                    return true;
                }
            }
            return false;
        }
    }
}
