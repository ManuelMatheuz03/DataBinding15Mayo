using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DataBinding
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListsPage : ContentPage
	{

        public List<Page> Paginas  { get; set; }

        public ListsPage ()
		{
			InitializeComponent ();
            Paginas = new List<Page>()
            {
                new BindingList(),
                new MainPage()


            };
            this.BindingContext = this;
            listaVista.ItemSelected += ListaVista_ItemSelected;

        }

        private void ListaVista_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                this.Navigation.PushAsync((Page)e.SelectedItem);
            }
            listaVista.SelectedItem = null;
        }
    }
}