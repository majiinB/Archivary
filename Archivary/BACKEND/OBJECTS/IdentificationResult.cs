using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivary.BACKEND.OBJECTS
{
    public class IdentificationResult
    {
        public int[] Sequence { get; set; }
        public string ErrorMessage { get; set; }
        public bool Success => string.IsNullOrEmpty(ErrorMessage);

        public static IdentificationResult CreateSuccess(int[] sequence)
        {
            return new IdentificationResult { Sequence = sequence };
        }

        public static IdentificationResult CreateError(string errorMessage)
        {
            return new IdentificationResult { ErrorMessage = errorMessage, Sequence = new int[0] };
        }
    }
}
