using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PedidoFacil.Controls
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ExpandableView : ContentView
	{
        private TapGestureRecognizer _tapRecogniser;

        private StackLayout _Summary;
        public virtual StackLayout Summary
        {
            get { return _Summary; }
            set
            {
                _Summary = value;
                SummaryRegion.Children.Add(_Summary);
                OnPropertyChanged();
            }
        }

        private StackLayout _Details;
        public virtual StackLayout Details
        {
            get { return _Details; }
            set
            {
                _Details = value;
                DetailsRegion.Children.Add(_Details);
                OnPropertyChanged();
            }
        }

        public ExpandableView()
        {
            InitializeComponent();
            InitializeGuestureRecognizer();
            SubscribeToGuestureHandler();

            DetailsRegion.IsVisible = false;
        }

        private void InitializeGuestureRecognizer()
        {
            _tapRecogniser = new TapGestureRecognizer();
            SummaryRegion.GestureRecognizers.Add(_tapRecogniser);
        }

        private void SubscribeToGuestureHandler()
        {
            _tapRecogniser.Tapped += TapRecogniser_Tapped;
        }

        private void TapRecogniser_Tapped(object sender, EventArgs e)
        {
            if (DetailsRegion.IsVisible)
            {
                DetailsRegion.IsVisible = false;
            }
            else
            {
                DetailsRegion.IsVisible = true;
            }
        }
    }
}