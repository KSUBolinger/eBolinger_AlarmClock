﻿using System;
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

namespace eBolinger_AlarmClock
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnAddButtonClicked(object sender, RoutedEventArgs e)
        {
            //string time = DateTime.Now.ToString("h:mm:ss tt");
            //MessageBox.Show("The time is; " + time);
            //AlarmList.Items.Add(time);


            uxAlarmCreation alarmCreation = new uxAlarmCreation();
            alarmCreation.Show();


            EditButton.IsEnabled = true;
            SnoozeButton.IsEnabled = true;
            StopButton.IsEnabled = true;
        }
    }
}
