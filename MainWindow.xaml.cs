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

namespace Cyberpunk2020CharacterCreator
{

    


    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Character bob = new Character();
            bob.age = 20;
            bob.lifeEvents = LifeEvents.GenerateLifeEvents(bob);
            string temp = "";
            foreach(KeyValuePair<int,string> valuePair in bob.lifeEvents)
            {
                temp += "\n Year " + valuePair.Key + ": " + bob.lifeEvents[valuePair.Key];
            }
            textBlock.Text = temp;
        }
    }
}
