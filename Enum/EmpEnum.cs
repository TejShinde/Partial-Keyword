﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumNamespace
{
        public enum Department { HR = 1, Sales, Dev, Testing, Admin }

        public enum Roles { Emp = 100, Manager = 200, CEO = 300, HRManager = 400 }
        public class EmpEnum
        {
            private int id;
            private string name;
            // we want to store dept id
            private Department dept;
            private Roles roles;

            public EmpEnum(int id, string name, Department dept, Roles roles)
            {
                this.id = id;
                this.name = name;
                this.dept = dept;
                this.roles = roles;
            }
            
            public override string ToString()
            {
                return $"{id}, {name} , {dept} ";
            }
        }
}
