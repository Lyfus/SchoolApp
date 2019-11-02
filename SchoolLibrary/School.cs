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
        //public float AverageThreeScores(float a, float b, float c)
        //{
        //    var result = (a + b + c) / 3;
        //    return result;
        //}

        // Expression "Bodied" de la fonction AverageThreeScores, ce qui permet de ne pas utiliser le mot clef "return"
        public static float AverageThreeScores(float a, float b, float c) => (a + b + c) / 3;
        // Méthode du même nom que celle avec le type de retour float, mais comme nous retournons
        // un nouveau type, celle ci est considérée comme nouvelle, et non comme une surcharge
        // Ici nous avons ajouté le mot clef "static" pour rendre la méthode accessible sans instanciation de la classe. 
        // Exemple : School.AverageThreeScores(1,2,3) sera accessible sans instancier un objet School
        public static int AverageThreeScores(int a, int b, int c)
        {
            var result = (a + b + c) / 3;
            return result;
        }

        // Exemple d'override, ici de la méthode ToString()
        // L'override sert à ajouter ou modifier l'utilisation primaire de la méthode de base.
        public override string ToString()
        {
            var sb = new StringBuilder();
            // this ici renvoie à l'instance x de la classe, ce qui nous permet
            // D'accèder à la propriété Name de l'objet School qui sera instancié
            // Cependant this est ici explicite et n'est pas nécéssaire.
            sb.AppendLine(this.Name);
            // Nous voyons que nous accèdons à la propriété Address malgré l'absence du mot clef "this"
            sb.AppendLine(Address);
            // Ici on remontre la construction d'une chaîne dites "complexe" avec un StringBuilder
            sb.Append(City);
            sb.Append(", ");
            sb.Append(State);
            sb.Append("  ");
            sb.Append(Zip);

            // Au lieu de retourne base.ToString(), c'est à dire la structure de l'objet
            // Nous retournons la chaîne sb, construite avec le StringBuilder
            return sb.ToString(); // Ici nous renverrons une chaine de format : 
            // {Name}
            // {Addresse}
            // {City}
            // ,{State}  {Zip}  
        }
    }
}
