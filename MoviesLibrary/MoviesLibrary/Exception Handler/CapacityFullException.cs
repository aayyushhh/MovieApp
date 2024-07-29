using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesLibrary
{
    public class CapacityFullException :Exception
    {
        public CapacityFullException(string message) : base(message)
        {

        }
    }
}

