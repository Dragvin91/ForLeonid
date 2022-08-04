using Avalonia.Controls;
using ReactiveUI.Fody.Helpers;

namespace ForLeonid.Project
{
    internal class ProjectViewModel:IProjectView
    {
        public ProjectViewModel()
        {
            GridProject = new Grid{ColumnDefinitions = new ColumnDefinitions("Auto,Auto,Auto,Auto,Auto,Auto,Auto,Auto,Auto,Auto,Auto,Auto,Auto") };
            var nameProject = new TextBlock {Text = "Проекты"};
            Grid.SetColumn(nameProject,0);
            GridProject.Children.Add(nameProject);
            var january = new TextBlock { Text = "Январь" };
            Grid.SetColumn(january, 1);
            GridProject.Children.Add(january);
            var february = new TextBlock { Text = "Февраль" };
            Grid.SetColumn(february, 2);
            GridProject.Children.Add(february);
            var march = new TextBlock { Text = "Март" };
            Grid.SetColumn(march, 3);
            GridProject.Children.Add(march);
            var april = new TextBlock { Text = "Апрель" };
            Grid.SetColumn(april, 4);
            GridProject.Children.Add(april);
            var may = new TextBlock { Text = "Май" };
            Grid.SetColumn(may, 5);
            GridProject.Children.Add(may);
            var june = new TextBlock { Text = "Июнь" };
            Grid.SetColumn(june, 6);
            GridProject.Children.Add(june);
            var july = new TextBlock { Text = "Июль" };
            Grid.SetColumn(july, 7);
            GridProject.Children.Add(july);
            var august = new TextBlock { Text = "Август" };
            Grid.SetColumn(august, 8);
            GridProject.Children.Add(august);
            var september = new TextBlock { Text = "Сентябрь" };
            Grid.SetColumn(september, 9);
            GridProject.Children.Add(september);
            var october = new TextBlock { Text = "Октябрь" };
            Grid.SetColumn(october, 10);
            GridProject.Children.Add(october);
            var november = new TextBlock { Text = "Ноябрь" };
            Grid.SetColumn(november, 11);
            GridProject.Children.Add(november);
            var december = new TextBlock { Text = "Декабрь" };
            Grid.SetColumn(december, 12);
            GridProject.Children.Add(december);
        }

        [Reactive] internal Grid GridProject { get; set; }
    }
}
