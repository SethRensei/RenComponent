using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RenTestComponent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RenTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsControl(e.KeyChar))
                // La touche est un chiffre, un espace ou une touche de contrôle (comme Retour arrière, Suppr, etc.)
                e.Handled = false; // Permettre la saisie de la touche
            else
                // La touche n'est pas un chiffre, un espace ou une touche de contrôle
                e.Handled = true;  // Annuler la saisie de la touche
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Person> people = new List<Person>()
            {
                new Person() { Id =  1, Name = "Alice"    }, new Person() { Id =  2, Name = "Bob"      },
                new Person() { Id =  3, Name = "Charlie"  }, new Person() { Id =  4, Name = "Diane"    },
                new Person() { Id =  5, Name = "Ethan"    }, new Person() { Id =  6, Name = "Fiona"    },
                new Person() { Id =  7, Name = "George"   }, new Person() { Id =  8, Name = "Helen"    },
                new Person() { Id =  9, Name = "Ian"      }, new Person() { Id = 10, Name = "Julia"    },
                new Person() { Id = 11, Name = "Kevin"    }, new Person() { Id = 12, Name = "Laura"    },
                new Person() { Id = 13, Name = "Michael"  }, new Person() { Id = 14, Name = "Nina"     },
                new Person() { Id = 15, Name = "Oliver"   }, new Person() { Id = 16, Name = "Paula"    }
            };

            // Exemple d'utilisation de UCRenComboBox
            cmbBoxAnimal.DataSource = people; // Assigner la source de données
            cmbBoxAnimal.DisplayMember = "Name"; // Propriété à afficher dans la liste déroulante
            cmbBoxAnimal.ValueMember = "Id"; // Propriété à utiliser comme valeur sélectionnée
        }

        private void CmbBoxAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show($"Vous avez sélectionné : {cmbBoxAnimal.SelectedValue}");
        }
    }

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
