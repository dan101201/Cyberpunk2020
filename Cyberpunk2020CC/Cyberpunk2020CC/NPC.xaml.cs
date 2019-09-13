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
    /// Interaction logic for NPC.xaml
    /// </summary>
    public partial class NPC : Page
    {
        Button template;

        public NPC(Button template)
        {
            InitializeComponent();
            this.template = template;
            Cyberpunk2020CharacterCreator.Character temp = new Cyberpunk2020CharacterCreator.Character("bob", true);
            AddButtonsForEachNPC();
        }

        void AddButtonsForEachNPC()
        {
            
            foreach (Cyberpunk2020CharacterCreator.Character c in Cyberpunk2020CharacterCreator.Character.NPCs)
            {
                Button _tempButton = (Button)Utility.DeepCopy(template);
                _tempButton.Content = c.name;
                characterPanel.Children.Add(_tempButton);
            }
            
        }
    }
}
