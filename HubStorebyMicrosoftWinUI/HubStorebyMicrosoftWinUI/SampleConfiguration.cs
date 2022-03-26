using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubStorebyMicrosoftWinUI
{
    internal static class SampleConfig
    {
        public const string FeatureName = "$safeprojectname$";
        public static ElementTheme CurrentTheme = ElementTheme.Default;
    }

    public partial class MainPage : Page
    {
        private readonly List<Scenario> scenarios = new()
        {
        };
    }

    public class Scenario
    {
        public string Title { get; set; }
        public string ClassName { get; set; }
    }
}
