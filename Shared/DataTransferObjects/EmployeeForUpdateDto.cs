﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public record EmployeeForUpdateDto
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
    }
    
    
}
