using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace LoginNavigation
{
    public enum AccessLevel
    {
        Admin,
        User
    }


    public class Employee : ModelObject
    {
        string name;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                if (Photo == null)
                    Photo = ImageSource.FromResource(value.Replace(" ", String.Empty));
            }
        } 

        public Employee(string name)
        {
            this.Name = name;
        }
        public int KodeUnit { get; set; }
        public int NoAgenda { get; set; }
        public string Address { get; set; }
        public string JP { get; set; }


        //yg dibawah ga ditampilin
        public ImageSource Photo { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }
        public string Position { get; set; }
        public string Phone { get; set; }
        public AccessLevel Access { get; set; }
        public bool OnVacation { get; set; }
    }

    public class ModelObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }

}
