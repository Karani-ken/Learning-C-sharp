using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookshop.Helpers
{
    public class Validate
    {
        public static bool Validation(List<string> inputs)
        {
            var isValid = false;
            foreach (var input in inputs)
            {
                if (string.IsNullOrWhiteSpace(input))
                {
                    isValid=false; break;
                }
                isValid = true;
            }
            return isValid;
        }
    }
}
