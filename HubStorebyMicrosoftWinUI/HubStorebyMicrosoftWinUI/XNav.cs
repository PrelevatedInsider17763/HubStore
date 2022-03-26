using Microsoft.UI.Xaml.Controls;
using Windows.UI.Xaml.Interop;

namespace HubStorebyMicrosoftWinUI
{
    public class XNav : NavigationView
    {
        public string v = "a";
        public XNav() 
        {
            NavigationView view = new();
            view = new NavigationView();
        }
        public string Title
        {
            get { return v; }
        }
    }
}