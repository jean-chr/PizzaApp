using System;
using PizzaApp.extension;

namespace PizzaApp.Models
{
    public class Pizza
    {

        public string Nom { get; set; }
        public int Prix { get; set; }
        public string[] Ingredient { get; set; }
        public string Prixdevice { get { return Prix + " FCFA"; } }
        public string ListIngredient { get { return String.Join(", ", Ingredient); } }
       // public string Titre { get{ return Nom.PremierletttreMaj(); } }

        public string Imageurl { get; set; }
        public Pizza() { }
    }



}
