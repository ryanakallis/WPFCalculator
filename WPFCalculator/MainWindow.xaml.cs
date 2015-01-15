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

namespace WPFCalculator
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

		private void Add_Click(object sender, RoutedEventArgs e)
		{
			int output = Int32.Parse(Number1.Text) + Int32.Parse(Number2.Text);
			Result.Text = output.ToString();
		}

		private void Subtract_Click(object sender, RoutedEventArgs e)
		{
			int output = Int32.Parse(Number1.Text) - Int32.Parse(Number2.Text);
			Result.Text = output.ToString();
		}

		private void Multiply_Click(object sender, RoutedEventArgs e)
		{
			int output = Int32.Parse(Number1.Text) * Int32.Parse(Number2.Text);
			Result.Text = output.ToString();
		}

		private void Divide_Click(object sender, RoutedEventArgs e)
		{
			int output = Int32.Parse(Number1.Text) / Int32.Parse(Number2.Text);
			Result.Text = output.ToString();
		}
	}
}
