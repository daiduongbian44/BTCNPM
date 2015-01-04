using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Windows.Controls.Ribbon;
using System.Resources;
using System.Threading;
using BTLViewRibbon.Cultures;
using System.Globalization;
using System.Diagnostics;
using BTLViewRibbon;

namespace BTLViewRibbon.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindowView : RibbonWindow
    {
        public MainWindowView()
        {
            CultureResources.ResourceProvider.DataChanged += new EventHandler(ResourceProvider_DataChanged);
            CultureResources.ChangeCulture(Properties.Settings.Default.DefaultCulture);
            InitializeComponent();

            this.cbLanguages.SelectionChanged += new SelectionChangedEventHandler(cbLanguages_SelectionChanged);
            cbLanguages.SelectedItem = Properties.Settings.Default.DefaultCulture;
        }

        void ResourceProvider_DataChanged(object sender, EventArgs e)
        {
            Debug.WriteLine(string.Format("ObjectDataProvider.DataChanged event. fetching culturename property for new culture"));
        }


        void cbLanguages_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CultureInfo selected_culture = cbLanguages.SelectedItem as CultureInfo;
            if (Properties.Resources.Culture != null && !Properties.Resources.Culture.Equals(selected_culture))
            {
                CultureResources.ChangeCulture(selected_culture);
            }
        }
    }
}
