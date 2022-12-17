using System;
using PizzaApp.extension;

namespace PizzaApp.Models
{
    public class Pizza
    {

        public string nom { get; set; }
        public int prix { get; set; }
        public string[] ingredient { get; set; }
        public string prixdevice { get { return prix + " FCFA"; } }
        public string listingredient { get { return String.Join(", ", ingredient); } }

       // public string Titre { get{ return Nom.PremierletttreMaj(); } }

        public string imageurl { get; set; }
        public Pizza() { }
    }



}
