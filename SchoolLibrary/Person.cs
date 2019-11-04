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

        // Méthode abstraite, devant être override pour être utilisée
        public abstract float ComputeGradeAverage();

        // Méthode virtuelle, méthode pouvant être modifié par le membre qui hérite de la classe Person
        public virtual string SendMessage(string message)
        {
            var sb = new StringBuilder();
            var timeStamp = string.Format("Send on {0:D} at {0:t}", DateTime.Now);

            sb.AppendLine(timeStamp);
            sb.AppendLine("");
            sb.AppendLine("Dead " + Firstname + ",");
            sb.AppendLine(message);

            return sb.ToString();
        }
    }
}
