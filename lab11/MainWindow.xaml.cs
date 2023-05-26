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
using System.Windows.Shapes;

namespace lab11
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();

            games.ItemsSource = new string[]
         {
                "Майнкрафт",
                "Террария",
                "Дурак",
                "Мафия",
                "Сапёр",
          };

            education.ItemsSource = new string[]
            {
                "Строительство",
                "Программирование",
                "Кулинария",
                "Иностранный язык",
                "Курсы по саморазвитию",
            };

        }

        void NumberOfOrders()
        {
            if (orders.Items.Count != 0)
            {
                numberOfOrders.Content = $"Количество заказов: {orders.Items.Count}";
            }
            else if (orders.Items.Count == 0)
            {
                numberOfOrders.Content = "";
            }
        }

        private void AddtoOrder(object sender, RoutedEventArgs e)
        {
            string selectedGame = games.SelectedItem as string;
            string selectedEdu = education.SelectedItem as string;

            if (selectedGame != null)
            {
                orders.Items.Add(selectedGame);
                games.SelectedItem = null;
            }
            else if (selectedEdu != null)
            {
                orders.Items.Add(selectedEdu);
                education.SelectedItem = null;
            }
            else
            {
                MessageBox.Show("Не выбрано ни одного элемента!", "Ошибка добавления", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            NumberOfOrders();

        }

        private void DeleteFromOrder(object sender, RoutedEventArgs e)
        {
            orders.Items.Remove(orders.SelectedItem);
            NumberOfOrders();
        }
    }
}
