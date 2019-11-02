using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    // Notre première classe du fichier "School"
    // !! RAPPEL : Par convention, Une class correspond à un fichier !!
    public class School
    {
        // Propriétés publiques "Auto-properties", c'est à dire qu'elles contiennent
        // Un accesseur(Get ou Getter) et un modifieur(Set ou Setter)
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }
        // Exemple d'un getter et setter plus avancé avec une propriété privée et publique. 
        // Ici nous avons une propriété privée accessible via la propriété publique TwitterAdresse
        // Nous ne pouvons pas intéragir directement _twitterAdresse via l'appel School._twitterAdresse
        private string _twitterAdresse { get; set; }
        // La propriété publique qui est appelée pour Get ou Set la propriété _twitterAdresse
        public string TwitterAdresse
        {
            get { return _twitterAdresse; }
            // Vérification de l'existance d'un "@" au début de l'adresse Twitter
            set
            {
                if(value.StartsWith("@"))
                {
                    _twitterAdresse = value;
                }
                else
                {
                    // Appel d'une Exception si l'adresse rentrée ne commence pas par un "@"
                    throw new Exception("The twitter address must begin with @");
                }
            }
        }

        #region USEFULL COMMENTED CODE
        // SchoolLibrary est affiché en gris car c'est une spécification qui est superflue
        // Généralement, sauf cas particulier, le développeur supprime les lignes grisées.
        // (Décommenter pour voir la coloration syntaxique)
        // SchoolLibrary.Elementary.Volume volume;
        #endregion
        // Exemple d'un constructeur
        // Raccourci : ctor puis tab, ceci donne un constructeur vide
        public School()
        {
            Name = "Untitled School";
            PhoneNumber = "555-123A";
        }

        // Surcharge du constructeur pour accueillir deux valeurs pour Name et PhoneNumber
        public School(string SchoolName, string SchoolPhoneNumber)
        {
            Name = SchoolName;
            PhoneNumber = SchoolPhoneNumber;
        }

        // Exemple d'une méthode de la classe School
        // Cette méthode sera disponible en instanciant la class School 

        // Exemple : School SUPINFO = new School();
        // School.AverageThreeScores(10.2, 18.7, 14,6)
        public float AverageThreeScores(float a, float b, float c)
        {
            var result = (a + b + c) / 3;
            return result;
        }

        // Méthode du même nom que celle avec le type de retour float, mais comme nous retournons
        // un nouveau type, celle ci est considérée comme nouvelle, et non comme une surcharge
        public int AverageThreeScores(int a, int b, int c)
        {
            var result = (a + b + c) / 3;
            return result;
        }
    }
}
