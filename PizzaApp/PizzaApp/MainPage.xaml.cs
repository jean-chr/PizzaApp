using Newtonsoft.Json;
using PizzaApp.Models;
using System.Collections.Generic;
using System.Net;
using Xamarin.Forms;

namespace PizzaApp
{
    public partial class MainPage : ContentPage
    {
        string PizzaJson;
        const string URL = "https://matix.li/669fe57a2925";
        List<Pizza> pizzas;

        public MainPage()
        {
            InitializeComponent();

            pizzas = new List<Pizza>();
            maliste.IsVisible = false;
            refresh.IsVisible = true;



            //refresh commande
            maliste.RefreshCommand = new Command(() =>
            {

                DownloadData((pizzas) =>
                {
                    maliste.ItemsSource = pizzas;
                    maliste.IsRefreshing = false;
                });
            });

            // chargement pizza
            DownloadData((pizzas) =>
            {
                maliste.IsVisible = true;
                refresh.IsVisible = false;
                maliste.ItemsSource = pizzas;
            });

            //on definit la source de la liste view
            maliste.ItemsSource = pizzas;

            //select pizza
            maliste.ItemSelected += (sender, e) =>
            {
                if (maliste.SelectedItem != null)
                {
                    Pizza item = maliste.SelectedItem as Pizza;
                    DisplayAlert("Pizza: " + item.nom, "Ingredients: " + item.listingredient, "OK" + item.prixdevice);
                    maliste.SelectedItem = null;

                }
            };
        }

        //recuperation pizza

        public void DownloadData(System.Action<List<Pizza>> action)
        {
            using (var webclient = new WebClient())
            {
                // PizzaJson = webclient.DownloadString(URL);
                // pizzas = JsonConvert.DeserializeObject<List<Pizza>>(PizzaJson);

                //foncion asynchrone 
                webclient.DownloadStringCompleted += (object sender, DownloadStringCompletedEventArgs e) =>
                {
                    try
                    {
                        PizzaJson = e.Result;
                        pizzas = JsonConvert.DeserializeObject<List<Pizza>>(PizzaJson);

                        Device.BeginInvokeOnMainThread(() =>
                        {
                            action.Invoke(pizzas);
                        });
                    }
                    catch (System.Exception ex)
                    {
                        Device.BeginInvokeOnMainThread(() =>
                        {
                            DisplayAlert("Erreur", "une erreur reseau " + ex.InnerException, "ok");
                        });
                        action.Invoke(null);

                    }
                };

                webclient.DownloadStringAsync(new System.Uri(URL));
            }
        }


    }
}
