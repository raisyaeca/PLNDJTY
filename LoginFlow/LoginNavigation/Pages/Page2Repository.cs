using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginNavigation
{
    public abstract class RepositoryPage2
    {
        readonly ObservableCollection<Page2Class> repositori2;
        public RepositoryPage2()
        {
            this.repositori2 = new ObservableCollection<Page2Class>();
        }
        public ObservableCollection<Page2Class> Repositori2
        {
            get { return repositori2; }
        }
    }
    public class Page2Repository : RepositoryPage2
    {
        public Page2Repository() : base()
        {
            GenerateTambahDaya();
        }
        void GenerateTambahDaya()
        {
            Repositori2.Add(
                new Page2Class("Dilan Mulyana")
                {
                    KodeUnit = 11,
                    NoAgenda = 131,
                    Address = "Tembalang, Semarang",
                    JP = "TD",

                    BirthDate = new DateTime(1978, 12, 8),
                    HireDate = new DateTime(2005, 5, 1),
                    Position = "Sales Representative",
                    Phone = "(206) 555-9857",
                    Access = AccessLevel.User,
                    OnVacation = false
                }
            );
            Repositori2.Add(
                new Page2Class("Milea Kuna")
                {
                    KodeUnit = 12,
                    NoAgenda = 132,
                    Address = "Banyumanik, Semarang",
                    JP = "TD",

                    BirthDate = new DateTime(1965, 2, 19),
                    HireDate = new DateTime(1992, 8, 14),
                    Position = "Vice President, Sales",
                    Phone = "(206) 555-9482",
                    Access = AccessLevel.Admin,
                    OnVacation = false
                }
            );
            Repositori2.Add(
                new Page2Class("Lucky Djalu")
                {
                    KodeUnit = 13,
                    NoAgenda = 133,
                    Address = "Gajahmungkur, Semarang",
                    JP = "TD",

                    BirthDate = new DateTime(1985, 8, 30),
                    HireDate = new DateTime(2002, 4, 1),
                    Position = "Sales Representative",
                    Phone = "(206) 555-3412",
                    Access = AccessLevel.User,
                    OnVacation = false
                }
            );
            Repositori2.Add(
                new Page2Class("Siti")
                {
                    KodeUnit = 12,
                    NoAgenda = 134,
                    Address = "Candisari, Semarang",
                    JP = "TD",

                    BirthDate = new DateTime(1973, 9, 19),
                    HireDate = new DateTime(1993, 5, 3),
                    Position = "Sales Representative",
                    Phone = "(206) 555-8122",
                    Access = AccessLevel.User,
                    OnVacation = false
                }
            );
            Repositori2.Add(
                new Page2Class("Farakajol")
                {
                    KodeUnit = 11,
                    NoAgenda = 135,
                    Address = "Ngaliyan, Semarang",
                    JP = "TD",

                    BirthDate = new DateTime(1955, 3, 4),
                    HireDate = new DateTime(1993, 10, 17),
                    Position = "Sales Manager",
                    Phone = "(71) 555-4848",
                    Access = AccessLevel.User,
                    OnVacation = true
                }
            );
        }
    }

}
