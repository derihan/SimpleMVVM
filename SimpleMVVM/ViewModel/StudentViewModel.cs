using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleMVVM.Model;
using System.Collections.ObjectModel;

namespace SimpleMVVM.ViewModel
{
    class StudentViewModel
    {
        public ObservableCollection<Student> Students 
        {
            get;
            set;
        }

        public void LoadStudents()
        {
            ObservableCollection<Student> students = new ObservableCollection<Student>
            {
                new Student{ Firstname = "Mark",Lastname="Allain" },
                new Student{ Firstname = "Allen", Lastname = "Brown" },
                new Student{ Firstname = "Linda",Lastname="Hamerski" }
            };

            Students = students;
        }
    }
}
