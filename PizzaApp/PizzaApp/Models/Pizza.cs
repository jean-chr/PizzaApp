using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaApp.Models
{
    public class Pizza
    {
        public string Nom { get; set; }
        public int Prix { get; set; }
        public string[] Ingredient { get; set; }
        public string Prixdevice { get { return Prix + " FCFA"; } }
        public string ListIngredient { get { return String.Join( " ", Ingredient); } }

        public string Imageurl { get; set; }
        public Pizza() { }
    }

 

}
