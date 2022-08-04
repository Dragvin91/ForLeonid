using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForLeonid.Project;

namespace ForLeonid.MainMenu
{
    internal class TopMenuViewModel
    {
        private GlobalVariable globalVariable = GlobalVariable.GetGlobalVariable();
        private ProjectView projectView;    
        public void OpenProjectWindow()
        {
            if (projectView == null)
            {
                projectView = new ProjectView();
                //(projectView.DataContext as IProjectView).Init
            }

            
            globalVariable.MainWindow.SetContent(projectView);
        }
    }
}
