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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Balloon> balloons = new List<Balloon>();
        private object rndGen;

        public MainWindow()
        {
            InitializeComponent();
            InitializeBalloons();




        }

        private void InitializeBalloons()
        {
            canvas.Children.Clear();
            balloons.Clear();
            Random rndGen = new Random();
            balloons.Clear();
            for (int i = 0; i < 100; i++)
            {
                Balloon balloon = new Balloon(canvas, rndGen);
                balloons.Add(balloon);
            }

        }

        private void growButton_Click(object sender, RoutedEventArgs e)
        {
            foreach(var b in balloons)
            {
                b.Grow();
            }
        }




        private void moveButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (var b in balloons)
            {
                b.Move();
            }
        }

        private void Initbutton_Click_1(object sender, RoutedEventArgs e)
        {
            InitializeBalloons();

        }


    }
}
