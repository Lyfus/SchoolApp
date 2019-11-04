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

        // Override de la méthode virtuelle SendMessage de Person
        public override string SendMessage(string message)
        {
            // base renvoit ici aux éléments de la méthode SendMessage dans Person
            var original = base.SendMessage(message);

            // Pour rappel, StringBuilder(string) permet de travailler sur un texte déjà imposé
            // Ou "Seed"
            var sb = new StringBuilder(original);
            sb.AppendLine("This message is private and confidential.");
            return sb.ToString();
        }
    }
}
