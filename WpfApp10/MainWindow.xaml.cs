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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp10
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            

            


        }


      

        private void button_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();

            animation.From = 0;

            animation.To = canvas.Width;

            animation.Duration = new Duration(TimeSpan.FromSeconds(1));

            //animation.RepeatBehavior = RepeatBehavior.Forever;

            //animation.AutoReverse = true;

            

            Storyboard storyboard = new Storyboard();

            storyboard.Children.Add(animation);

            Storyboard.SetTargetName(animation, rectangle.Name);

            Storyboard.SetTargetProperty(animation, new PropertyPath(WidthProperty));

            storyboard.Begin(this);

            animation.Completed += Show;
        }


        public void Show(object sender, EventArgs e)
        {
            MessageBox.Show("Загрузка загрузилась");
        }
    }
}
