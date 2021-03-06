﻿using System;
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
using System.Windows.Shapes;

namespace Stock
{
    /// <summary>
    /// InputMoney.xaml 的交互逻辑
    /// </summary>
    public partial class InputMoney : Window
    {
        public InputMoney()
        {
            InitializeComponent();
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            m = 0;
            n = "";
            this.Close();
        }
        public double m;
        public string n;
        private void ButtonOK_Click(object sender, RoutedEventArgs e)
        {
            n = name.Text;
            if (Double.TryParse(money.Text, out m) && m != 0)
            {
                if (m > 99999999.99)
                {
                    MessageBox.Show("本金设置最大值为99999999.99元！");
                    return;
                }
                this.Close();
            }
            else
                MessageBox.Show("错误的本金金额！");
        }
    }
}
