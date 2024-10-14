using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class Members
    {
        internal string Name { get; }
        internal bool IsStudent { get; }

        internal Members(string name, bool isStudent)
        {
            Name = name;
            IsStudent = isStudent;
        }
    }
    }

