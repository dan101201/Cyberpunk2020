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
using Cyberpunk2020CharacterCreator;

namespace Cyberpunk2020CC
{
    /// <summary>
    /// Interaction logic for Character.xaml
    /// </summary>
    public partial class Character : Page
    {
        public Character(StackPanel _stack)
        {
            InitializeComponent();
            AddButtonsForEachCharacter(_stack);
        }

        void AddButtonsForEachCharacter(StackPanel _stack)
        {
            
            Button tempBtn = Utility.DeepCopy((Button)_stack.Children[0]);
            tempBtn.Content = "test";

            _stack.Children.Add(tempBtn);
        }
    }
}
