using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public abstract class Person
    {
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        // Méthode abstraite 
        public abstract float ComputeGradeAverage();
    }
}
