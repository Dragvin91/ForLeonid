using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avalonia.Controls;
using ReactiveUI.Fody.Helpers;

namespace ForLeonid.Employee
{
    internal class EmployeeViewModel
    {
        internal ObservableCollection<EmployeeForDataGrid> employees;

        public EmployeeViewModel()
        {
            employees = new();
        }

        public void Method()
        {
            var currentDay = DateTime.Today;
            var numberBeforMounth = (currentDay.Month - 1)==0 ? 12: currentDay.Month - 1;
            int yearBefor = numberBeforMounth == 12 ? currentDay.Year - 1 : currentDay.Year;
            var countDaysBeforMounts = DateTime.DaysInMonth(yearBefor, numberBeforMounth);

        }
    }

    internal class EmployeeForDataGrid
    {
        [Reactive] internal string FIO { get; set; }
        [Reactive] internal string Position { get; set; }
        [Reactive] internal int CountTask { get; set; }
        [Reactive] internal string EB { get; set; }
        [Reactive] internal string NameFirstMounth { get; set; }
        [Reactive] internal Grid GridDaysFirstMounth { get; set; }
        [Reactive] internal Grid GridFirstMounth { get; set; }
        [Reactive] internal string NameSecondMounth { get; set; }
        [Reactive] internal Grid GridDaysSecondMounth { get; set; }
        [Reactive] internal Grid GridSecondMounth { get; set; }
        [Reactive] internal string NameThirdMounth { get; set; }
        [Reactive] internal Grid GridDaysThirdMounth { get; set; }
        [Reactive] internal Grid GridThirdMounth { get; set; }
    }
}
