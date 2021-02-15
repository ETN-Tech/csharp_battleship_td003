// importation des espaces de nommage utiles
using System;


// Ajout de classes dans l'espace de nommage BatNav de l'application
namespace BatNav
{
    public class Guid
    {
        public void NewGuid()
        {
            Random aleatoire = new Random();
            int id = aleatoire.next(0000, 9999);
        }
    }

    public class DateTime
    {

    }

    public class Gamer
    {
        // @TODO010 CLASSE

        private Guid id { get; set; }
        public string pseudo { get; set; }
        public DateTime _creationDate;

        public ID(Guid id)
        {

        }

        public unknown(string pseudo, Guid id)
        {

        }
    }
}
