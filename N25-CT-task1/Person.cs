﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N25_CT_task1
{
    internal class Person
    {
        public Person(int id,string name, int age) 
        {
            Id = id;
            Name = name;
            Age = age;
        }
        public int Id { get; set; } 
        public string Name { get; set; }
        public int Age { get; set; }
        
    }
}
