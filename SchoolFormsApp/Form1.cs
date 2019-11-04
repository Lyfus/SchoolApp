using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Ici on voit la référence à la Librairie SchoolLibrary qui nous permet d'utiliser la class
// ne pas oublier de mettre SchoolLibrary dans les références via click droit sur Références et ajouter
using SchoolLibrary;

namespace SchoolFormsApp
{
    public partial class Form1 : Form
    {
        // Ne pas tenir compte de ce bloc, ce n'est pas le sujet du cours
        public Form1()
        {
            InitializeComponent();
        }

        private void PushToTest_Click(object sender, EventArgs e)
        {
            // Instantiation d'une nouvelle instance de School 
            var testSchool = new School();

            // Récupération des données du formulaire
            testSchool.Name = txtName.Text;
            testSchool.Address = txtAddress.Text;
            testSchool.City = txtCity.Text;
            testSchool.State = txtState.Text;
            testSchool.Zip = txtZip.Text;
            testSchool.PhoneNumber = txtPhone.Text;


            // Bloc Try-Catch qui permet de capturer les erreurs et les traiter
            // Ici un exemple avec l'essai de "Set" avec la valeur récupèrée du formulaire
            try
            {
                testSchool.TwitterAdresse = txtTwitter.Text;
            }
            catch(Exception ex)
            {
                // Ouverture d'une boite d'alert avec le message d'erreur
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show(testSchool.ToString());
            // Exemple de la vidéo avec le test d'une mauvaise entrée de TwitterAdresse
            // Entrée de TwitterAdresse invalide provoquant une erreur
            //testSchool.TwitterAdresse = "invalid name";

            // Vérification que la class Person ne peux pas être instanciée
            //var student = new Person(); // Ne fonctionne pas car Person est abstraite
            var teacher = new Teacher();
        }

        private void btnTestTeacher_Click(object sender, EventArgs e)
        {
            var teacher = new Teacher();
            var gp = teacher.ComputeGradeAverage();
            MessageBox.Show("The teacher's grade average is " + gp);
        }

        private void btnTestStudent_Click(object sender, EventArgs e)
        {
            {
                var student = new Student();
                var gp = student.ComputeGradeAverage();
                MessageBox.Show("The student's grade average is " + gp);
            }
        }
    }
}
