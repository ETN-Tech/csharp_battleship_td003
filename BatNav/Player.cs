// importation des espaces de nommage utiles
using System;

// Ajout de classes dans l'espace de nommage BatNav de l'application
namespace BatNav
{
    // Classe Player : Gère les informations d'un joueur pour une partie
    // Ces informations sont liées à son état pour la partie en cours.
    // Il doit être envisagé de créer un type de base : Gamer par exemple
    // qui fournirait les informations d'identité du joueur.
    // Le gamer est attaché à plusieurs parties en même temps.
	// @TODO011
    public class Player : Gamer
	{

        // nombre de de tirs ayant touché un bateau
        public int NbStruck { get; set; }

        // nombre de tirs restants pour le joueur
        int RemainStrike { get; set; }

        // status du joueur
        public AppDef.PlayerStatus Status { get; set; }

    }	
}
