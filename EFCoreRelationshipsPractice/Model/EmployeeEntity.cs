﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreRelationshipsPractice.Model
{
    public class EmployeeEntity
    {
        public EmployeeEntity() { }

        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }
    }
}
