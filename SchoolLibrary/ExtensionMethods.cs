using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    // Classe statique ExtensionMethods permettant d'étendre les fonctions accessibles des objets string
    public static class ExtensionMethods
    {
        // Cela est possible car nous passon this string, qui permet de récupérer le contexte de
        // l'objet string
        public static int WordCount(this string str)
        {
            var wordCount = str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
            return wordCount;
        }
    }
}
