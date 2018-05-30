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

namespace Library
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Book> book = new List<Book>();
        public MainWindow()
        {
            InitializeComponent();
            book.Add(new Book() { Name = "Eleanor Oliphant Is Completely Fine", Author = " Gail Honeyman", Year= 2018,Genre=Genre.drama,imgPath = @"C:\Users\User.STEP.001\Desktop\EO.png"});
            book.Add(new Book() { Name = "The Hitchhiker's Guide to the Galaxy ", Author = "Douglas Adams", Year = 2001, Genre = Genre.fantastic, imgPath = @"C:\Users\User.STEP.001\Desktop\386162.jpg" });
            book.Add(new Book() { Name = "Diary of Tracy Bicker", Author = "Jacqueline Wilson", Year = 2002, Genre = Genre.childrens, imgPath = @"C:\Users\User.STEP.001\Desktop\462684.jpg" });
            lv.ItemsSource = book;
          
        }

        private void view_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

//