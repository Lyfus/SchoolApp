using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public class EnglishPaper
    {
        public string Title { get; set; }
        public int MinimumWordCount { get; set; }
        public string PaperText { get; set; }
        public int WordCount
        {
            // Nous avons maintenant accès à l'extention de méthode sur l'objet string, ici la propriété PaperText
            get { return PaperText.WordCount(); }
        }
    }
}
