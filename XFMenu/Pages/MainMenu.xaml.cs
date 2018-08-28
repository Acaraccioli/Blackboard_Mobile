using System;
using System.Collections.Generic;
using Xamarin.Forms;
using XFMenu.Models;

namespace XFMenu.Pages
{
    public partial class MainMenu : MasterDetailPage
    {
        public List<MainMenuItem> MainMenuItems { get; set; }

        public MainMenu()
        {
            // Set the binding context to this code behind.
            BindingContext = this;


            // Build the Menu
            MainMenuItems = new List<MainMenuItem>()
    		{
    			new MainMenuItem() { Title = "Inicio", TextColor="Black" , Icon = "home.png", TargetType = typeof(PageOne) },
    			new MainMenuItem() { Title = "Clases", Icon = "book.png", TargetType = typeof(PageTwo) },
                new MainMenuItem() { Title = "Comunidad", Icon = "community.png", TargetType = typeof(PageTwo) },
                new MainMenuItem() { Title = "Notificaciones", Icon = "notification.png", TargetType = typeof(PageTwo) },
                new MainMenuItem() { Title = "Ayuda Blackboard", Icon = "ask.png", TargetType = typeof(PageTwo) },
                new MainMenuItem() { Title = "Editar Usuario", Icon = "edit.png", TargetType = typeof(PageTwo) },
                new MainMenuItem() { Title = "Salir", Icon = "exit.png", TargetType = typeof(PageTwo) }

            };

            // Set the default page, this is the "home" page.
            Detail = new NavigationPage(new PageOne());

    		InitializeComponent();
        }

    	// When a MenuItem is selected.
    	public void MainMenuItem_Selected(object sender, SelectedItemChangedEventArgs e)
    	{
    		var item = e.SelectedItem as MainMenuItem;
    		if (item != null)
    		{
    			if (item.Title.Equals("Inicio"))
    			{
                    
    				Detail = new NavigationPage(new PageOne());
    			}
    			else if (item.Title.Equals("Clases"))
    			{
    				Detail = new NavigationPage(new PageLoad());
    			}
                else if (item.Title.Equals("Comunidad"))
                {
                    Detail = new NavigationPage(new PageOne());
                }
                else if (item.Title.Equals("Notificaciones"))
                {
                    Detail = new NavigationPage(new PageOne());
                }
                else if (item.Title.Equals("Salir"))
                {
                    Navigation.PushModalAsync(new PageTwo());

                }
                MenuListView.SelectedItem = null;
    			IsPresented = false;
    		}
    	}
    }
}
