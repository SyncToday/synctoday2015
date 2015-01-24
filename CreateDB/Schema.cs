using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateDB
{
    class Schema
    {
        public IEnumerable<Func<dynamic>> Scripts()
        {
            yield return stringEmpty; 
        }

        public string stringEmpty()
        {
            return string.Empty;
        }
    }
}
