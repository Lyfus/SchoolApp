using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    // Ici Teacher hérite de la class Abstraite (Non instanciable) Person,
    // Récupérant ainsi ses propriétés et méthodes
    public class Teacher : Person
    {
        public string Subject { get; set; }

        // Override de la méthode abstraite de Person, qui doit être implémentée
        // Pour que l'héritage fonctionne
        public override float ComputeGradeAverage()
        {
            return 0.0f;
        }
    }
}
