﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HelloXamarinForms
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void OnClick(object sender, EventArgs e)
        {
            string name = helloText.Text;

            helloLabel.Text = "Hello " + name;
            
            
             
        }
    }
}
