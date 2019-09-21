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
using Cyberpunk2020CharacterCreator;

namespace Cyberpunk2020CC
{
    /// <summary>
    /// Interaction logic for Character.xaml
    /// </summary>
    public partial class Character : Page
    {

        Button _template;

        public Character(Button template)
        {
            InitializeComponent();
            this._template = template;  
        }

        void AddButtonsForEachCharacter()
        {
            Button tempButton = (Button)Utility.DeepCopy(_template);
            tempButton.Content = "Temp";
            characterPanel.Children.Add(tempButton);
        }
    }
}
