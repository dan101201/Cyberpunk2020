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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Interop;
using Cyberpunk2020CharacterCreator;

namespace Cyberpunk2020CC
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

        

        private void BtnClickP1(object sender, RoutedEventArgs e)
        {
            Main.Content = new Character((Button)ButtonHolder.Children[0]);
        }

        private void BtnClickP2(object sender, RoutedEventArgs e)
        {
            Main.Content = new Npc((Button)ButtonHolder.Children[1]);
        }

    }



}
