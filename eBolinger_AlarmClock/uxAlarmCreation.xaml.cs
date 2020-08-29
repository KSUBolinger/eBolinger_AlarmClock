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
using System.Windows.Shapes;

namespace eBolinger_AlarmClock
{
    /// <summary>
    /// Interaction logic for uxAlarmCreation.xaml
    /// </summary>
    public partial class uxAlarmCreation : Window
    {
        MainWindow main = new MainWindow();
        public uxAlarmCreation()
        {
            InitializeComponent();
            //TimeDisplay.Text = DateTime.Now.ToString("hh:mm:ss tt");
            //main.AlarmList.Items.Add(TimeDisplay.Text);
        }

        private void OnButtonClick(object sender, RoutedEventArgs e)
        {
            if(sender is Button button)
            {
                if((string)button.Name == "SetButton")
                {
                    main.AlarmList.Items.Add(TimeDisplay.Text);
                    this.Close();
                }
                else if((string)button.Name == "CancelButton")
                {
                    this.Close();
                }
            }
        }
    }
}
