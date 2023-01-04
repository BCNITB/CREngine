using CREditor.GameProject;
using System.Windows;
using System.Windows.Controls;

namespace CREditor.Editors
{
    /// <summary>
    /// Lógica de interacción para ProjectLayoutView.xaml
    /// </summary>
    public partial class ProjectLayoutView : UserControl
    {
        public ProjectLayoutView()
        {
            InitializeComponent();
        }

        /*private void OnAddScene_Button_Click(object sender, RoutedEventArgs e)
        {
            var vm = DataContext as Project;
            vm.AddScene("Nova Escena " + vm.Scenes.Count);
        }*/
    }
}
