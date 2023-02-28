using System;
using System.Collections.Generic;
using System.Linq;
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
    public partial class Input_Text : UserControl
    {
        // Type "propdp" to auto-generate this code.
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Text.  This enables binding.
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(Input_Text), 
                new FrameworkPropertyMetadata("Unassigned", FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        public Input_Text()
        {
            InitializeComponent();
            //this.DataContext = this;  <-- PITFALL: DO NOT SET THIS. 

            // Our control will inherit the DataContext wherever it is used.  
            // So how do we bind to Text inside this control?  We use a relative source.
            // That is what the `ElementName=ui_input_text` does.
        }
    }
}
