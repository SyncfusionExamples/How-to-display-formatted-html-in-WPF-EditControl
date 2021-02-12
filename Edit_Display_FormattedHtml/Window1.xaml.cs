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
using Syncfusion.Windows.Edit;
using Syncfusion.Windows.Shared;
using System.Text.RegularExpressions;

namespace IronPythonDemo
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        /// <summary>
        /// Window Constructor and events initialization
        /// </summary>
        public Window1()
        {
            InitializeComponent();
            //EditControl edit1 = new EditControl() { Background = Brushes.White, DocumentLanguage=Languages.HTML,DocumentSource= "../../Utlis/HTMLSource.html" };
            //this.Content = edit1;

        }
        
    }

}
