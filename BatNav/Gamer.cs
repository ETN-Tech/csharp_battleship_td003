// importation des espaces de nommage utiles
using System;


// Ajout de classes dans l'espace de nommage BatNav de l'application
namespace BatNav
{
    public class Gamer
    {
        // @TODO010 CLASSE

        public Guid ID { get; }
        public string Pseudo { get; set; }
        private DateTime CreationDate { get; set; }

        /**
         * CONSTRUCTORS
         */
        public Gamer(string pseudo)
        {
            ID = Guid.NewGuid();
            Pseudo = pseudo;
            CreationDate = DateTime.UtcNow;
        }
        
        public Gamer(Guid id, string pseudo)
        {
            ID = id;
            Pseudo = pseudo;
            CreationDate = DateTime.UtcNow;
        }
    }
}
