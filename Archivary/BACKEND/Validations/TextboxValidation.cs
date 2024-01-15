using RoundedCorners;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivary.BACKEND.Validations
{
    public class TextboxValidation
    {
        /// <summary>
        /// A utility class that simply sets the textbox into a number-only textbox
        /// </summary>
        /// <param name="textbox"></param>
        public static void NumberBox (RoundedTextBox textbox)
        {
            StringBuilder result = new StringBuilder();

            foreach (char letter in textbox.Text)
            {
                if (char.IsDigit(letter)) result.Append(letter);               
            }

            textbox.Text = result.ToString();
        }

        /// <summary>
        /// Returns true if any given textboxes in the parameter is null or empty.
        /// </summary>
        /// <param name="textboxes"></param>
        /// <returns></returns>
        public static bool CheckIfTextBoxesAreEmpty(params RoundedTextBox[] textboxes)
        {
            foreach (RoundedTextBox textbox in textboxes)
            {
                if (string.IsNullOrEmpty(textbox.Text)) return true;
            }
            return false;
        }
    }
}
