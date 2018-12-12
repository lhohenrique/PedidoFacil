using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PedidoFacil.Views
{
	public partial class MainPage : MasterDetailPage
    {
        private Stack<Type> PagesStack;

		public MainPage ()
		{
			InitializeComponent ();

            // Define a propriedade ItemSource da pagina MainPage.xaml
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(PedidosPage)));

            PagesStack = new Stack<Type>();
            PagesStack.Push(typeof(PedidosPage));
        }

        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (Models.MenuItem)e.SelectedItem;
            //obtem o tipo de objeto 
            Type pagina = item.TargetType;

            //abre a pagina correspondente ao item selecionado
            //Cria uma instância do tipo especificado usando o construtor
            //que melhor se adequa ao parametro informado
            Detail = new NavigationPage((Page)Activator.CreateInstance(pagina));
            IsPresented = false;

            PagesStack.Push(pagina);
        }

        protected override bool OnBackButtonPressed()
        {
            // check if there is page to navigate back
            if (PagesStack.Count > 1)
            {
                // Remove the current page at the top of the stack
                PagesStack.Pop();

                // Get the last page at the top of the stack
                var lastPage = PagesStack.Peek();

                Detail = new NavigationPage((Page)Activator.CreateInstance(lastPage));
                IsPresented = false;

                return true;
            }
            else
            {
                return base.OnBackButtonPressed();
            }
        }
    }
}