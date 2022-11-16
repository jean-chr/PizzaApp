
using PizzaApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PizzaApp
{
    public partial class MainPage : ContentPage
    {
            List<Pizza> pizzalist;
        public MainPage()
        {
            InitializeComponent();
            pizzalist = new List<Pizza>();
            
            pizzalist.Add(new Pizza { Nom = "carnivore", Prix = 5000, Ingredient = new string[]{ "tomato" } });
            pizzalist.Add(new Pizza { Nom = "vegetarienne", Prix = 7000, Ingredient = new string[]{ "Tomote", "oignon"} });
            pizzalist.Add(new Pizza { Nom = "Montagnarde", Prix = 2500, Ingredient = new string[] { "Tomote", "oignon" ,"Fromage","poivron"} });
            
            
            //on definit la source de la liste view
           maliste.ItemsSource = pizzalist;
        }

        private void Label_SizeChanged(object sender, EventArgs e)
        {

        }
    }
}
