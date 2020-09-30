using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp9
{
    class ParameterNullValidation
    {
        void Insert(string s)
        {
            if (s is null)
            {
                throw new ArgumentNullException(nameof(s));
            }
        }

        //// C# Next
        //void Insert(string s!!)
        //{

        //}
    }
}
