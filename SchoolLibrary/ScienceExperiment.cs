using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    // Héritage de la classe ScienceExperiment de l'interface IScored
    public class ScienceExperiment : IScored
    {
        public string Hypothesis { get; set; }
        public string Materials { get; set; }
        public string Method { get; set; }
        public string Conclusion { get; set; }
        // Propriétés implémentées depuis interface (raccourci d'implémentation automatique)
        // Ici on a enlevé les throw d'exceptions ecrites par défaut par VS
        public float Score { get; set; }
        public float MaximumScore { get; set; }
    }
}
