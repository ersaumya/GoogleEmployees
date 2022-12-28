using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.RequestFeatures
{
    public class EmployeeParameters:RequestParameters
    {
        //For Filtering
        public uint MinAge { get; set; }
        public uint MaxAge { get; set; } = int.MaxValue;
        public bool ValidAgeRange => MaxAge > MinAge;

        //For searching
        public string? SearchTerm { get; set; }
    }
}
