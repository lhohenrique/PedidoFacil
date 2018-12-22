using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PedidoFacil.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PedidosPage : TabbedPage
	{
		public PedidosPage ()
		{
			InitializeComponent ();
		}

        private void PedidosSentList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}