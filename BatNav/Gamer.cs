// importation des espaces de nommage utiles
using System;


// Ajout de classes dans l'espace de nommage BatNav de l'application
namespace BatNav
{
    public class Gamer
    {
        // @TODO010 CLASSE

        private Guid Id { get; }
        private string Pseudo { get; set; }
        private DateTime CreationDate { get; set; }

        /**
         * CONSTRUCTORS
         */
        public Gamer(string pseudo)
        {
            Id = Guid.NewGuid();
            Pseudo = pseudo;
            CreationDate = DateTime.UtcNow;
        }
        
        public Gamer(Guid id, string pseudo)
        {
            Id = id;
            Pseudo = pseudo;
            CreationDate = DateTime.UtcNow;
        }
    }
}
