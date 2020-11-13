using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace SimpleMVVM.Model
{
   
    public class StudentModel{ }

    public class Student : INotifyPropertyChanged
    {
        

        private string firstName;
        private string lastName;

        public string Firstname
        {
            get {
                return firstName;
            }
            set {
                if(firstName != value)
                {
                    firstName = value;
                    RaisePropertyChanged("FirstName");
                    RaisePropertyChanged("Fullname");
                }
            }
        }

        public string Lastname
        {
            get { return lastName; }
            set
            {
                if(lastName != value)
                {
                    lastName = value;
                    RaisePropertyChanged("Lastname");
                    RaisePropertyChanged("Fullname");
                }
            }
        }

        public string Fullname
        {
            get { return firstName + " " + lastName; }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string property)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

    }


}
