using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public class Student : Person
    {
        public enum GradeLevels { Freshman, Sophomore, Junior, Senior }
        public GradeLevels GradeLevel { get; set; }

        // Override de la méthode abstraite de Person, qui doit être implémentée
        // Pour que l'héritage fonctionne
        public override float ComputeGradeAverage()
        {
            return 4.0f;
        }
    }
}
