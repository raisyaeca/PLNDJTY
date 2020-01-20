using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LoginNavigation
{

    public enum AccessLevel1
    {
        Admin,
        User
    }


    public class RekapClass : ModelObject1
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

        public RekapClass(string name)
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

    public class ModelObject1 : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }

}
