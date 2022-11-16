
using PizzaApp.Models;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace PizzaApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            List<Pizza> pizzalist = new List<Pizza>
            {
                new Pizza { Nom = "carnivore", Prix = 5000, Ingredient = new string[] { "tomato" } ,Imageurl="https://fr.pizzamatch.com/assets/img/izr/1200_628/assets/img/2.jpg"},
                new Pizza { Nom = "vegetarienne", Prix = 7000, Ingredient = new string[] { "Tomote", "oignon" },Imageurl="https://fr.pizzamatch.com/assets/img/izr/1200_628/assets/img/4.jpg"},
                new Pizza { Nom = "Montagnarde", Prix = 2500, Ingredient = new string[] { "Tomote", "oignon", "Fromage", "poivron" },Imageurl="https://fr.pizzamatch.com/assets/img/izr/1200_628/assets/img/5.jpg" }
            };


            //on definit la source de la liste view
            maliste.ItemsSource = pizzalist;

            maliste.ItemSelected += (sender, e) => {
                if (maliste.SelectedItem != null) {

                    Pizza item = maliste.SelectedItem as Pizza;
                    DisplayAlert("Pizza: "+item.Nom, " Ingredients:"+item.ListIngredient,"OK"+item.Prixdevice);
                    maliste.SelectedItem = null;

                }
            };


        }

    }
}
