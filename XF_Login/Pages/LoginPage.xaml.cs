using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
//using XF_Login.ViewModels;

namespace XF_Login.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {


        public class Covid
        {
            public string evaxId { get; set; }
            private string cin { get; set; }
            private string firstName { get; set; }
            private string lastName { get; set; }
            private string tel { get; set; }


        }
        public LoginPage()
        {

            //var vm = new LoginViewModel();
            //this.BindingContext = vm;
            //vm.DisplayInvalidLoginPrompt += () => DisplayAlert("Error", "Invalid Login, try again", "OK");
            InitializeComponent();

            evaxId.Completed += (object sender, EventArgs e) =>
           {
               cin.Focus();
           };

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var url = $"https://curdrestapi.azurewebsites.net/api/listId/{evaxId.Text}";
            var client = new HttpClient();





            var result = await client.GetStringAsync(url);


            try
            {
                var blub = JsonConvert.DeserializeObject(result);
                foreach (var element in (JArray)blub)
                {
                    var yourEvax = ((JObject)element).SelectToken("$.evaxId").ToString();
                    var yourName = ((JObject)element).SelectToken("$.firstName").ToString();

                    LabelResults.Text = "you are allowed to enter" + yourName + "your evaxId is =  " + yourEvax;

                }


            }catch(Exception ex)
            {
                LabelResults.Text = "not found";

            }



        }


    }
    }




