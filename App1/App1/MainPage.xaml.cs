using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //Image image = new Image { Source = "plan.png" };
            //this.Content = image;

            /*
             //если картинка лежит в общем проекте
            Image image = new Image();
            image.Source = ImageSource.FromResource("App1.Images.Plan.png");
            Content = image;
            */
            


            /*
            AbsoluteLayout absoluteLayout = new AbsoluteLayout();
            absoluteLayout.Children.Add(
                new BoxView { Color = Color.LightBlue },
                new Rectangle(70, 70, 200, 70)
            );
            absoluteLayout.Children.Add(
                new Label { Text = "Xamarin Forms", FontSize = 20 },
                new Rectangle(110, 90, 150, 60)
            );
            absoluteLayout.Children.Add(
                new Label { Text = "Welcome to Xamarin World!!!!!!!!!!!", FontSize = 16 },
                new Point(70, 150)
            );
            Content = absoluteLayout;
            */
        }

        private void but_Clicked(object sender, EventArgs e)
        {
            //but.Text = "111";
           

        }

        private void Student_Clicked(object sender, EventArgs e)
        {
            //Student.ise
        }

        private void Teacher_Clicked(object sender, EventArgs e)
        {

        }
    }
}
