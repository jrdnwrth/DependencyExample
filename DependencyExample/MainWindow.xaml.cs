using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DependencyExample
{
    /// <summary>
    /// Note: You usually have two choices when implementing MVVM: dependency properties or INotifyPropertyChange.
    /// Usually, INotifyPropertyChange is the most common.  Here is a general rule:
    /// 
    /// 1. For XAML controls, use dependency properties;
    /// 2. For data(which you bind to in the interface), use INotifyPropertyChanged.
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// The value of this variable will change as we type in the TextBox.
        /// The really fancy part is that 
        /// </summary>
        public string name { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            // Without this line, our `{Binding name}` would know to look for a variable called "name",
            // but wouldn't know what object to look at.  We are telling telling it to look at `this` object for that variable.
            // All its child-controls will inherit the same DataContext unless told otherwise.
            this.DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(name);
        }
    }
}
