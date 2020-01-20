using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginNavigation
{
    public abstract class RepositoryRekap
    {
        readonly ObservableCollection<RekapClass> reposrekap;

        public RepositoryRekap()
        {
            this.reposrekap = new ObservableCollection<RekapClass>();
        }

        public ObservableCollection<RekapClass> ReposRekap
        {
            get { return reposrekap; }
        }
    }

    public class RekapRepository : RepositoryRekap
    {
        public RekapRepository() : base()
        {
            GenerateDataRekap();
        }

        void GenerateDataRekap()
        {
            ReposRekap.Add(
                new RekapClass("Dilan Mulyana")
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
            ReposRekap.Add(
                new RekapClass("Milea Kuna")
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
            ReposRekap.Add(
                new RekapClass("Lucky Djalu")
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
            ReposRekap.Add(
                new RekapClass("Siti")
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
            ReposRekap.Add(
                new RekapClass("Farakajol")
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
            ReposRekap.Add(
                new RekapClass("Budi")
                {
                    KodeUnit = 11,
                    NoAgenda = 131,
                    Address = "Tembalang, Semarang",
                    JP = "PB",

                    BirthDate = new DateTime(1978, 12, 8),
                    HireDate = new DateTime(2005, 5, 1),
                    Position = "Sales Representative",
                    Phone = "(206) 555-9857",
                    Access = AccessLevel.User,
                    OnVacation = false
                }
            );
            ReposRekap.Add(
                new RekapClass("Setyo Novanto")
                {
                    KodeUnit = 12,
                    NoAgenda = 132,
                    Address = "Banyumanik, Semarang",
                    JP = "PB",

                    BirthDate = new DateTime(1965, 2, 19),
                    HireDate = new DateTime(1992, 8, 14),
                    Position = "Vice President, Sales",
                    Phone = "(206) 555-9482",
                    Access = AccessLevel.Admin,
                    OnVacation = false
                }
            );
            ReposRekap.Add(
                new RekapClass("Harris Asrofi")
                {
                    KodeUnit = 13,
                    NoAgenda = 133,
                    Address = "Gajahmungkur, Semarang",
                    JP = "PB",

                    BirthDate = new DateTime(1985, 8, 30),
                    HireDate = new DateTime(2002, 4, 1),
                    Position = "Sales Representative",
                    Phone = "(206) 555-3412",
                    Access = AccessLevel.User,
                    OnVacation = false
                }
            );
            ReposRekap.Add(
                new RekapClass("Sutedja")
                {
                    KodeUnit = 12,
                    NoAgenda = 134,
                    Address = "Candisari, Semarang",
                    JP = "PB",

                    BirthDate = new DateTime(1973, 9, 19),
                    HireDate = new DateTime(1993, 5, 3),
                    Position = "Sales Representative",
                    Phone = "(206) 555-8122",
                    Access = AccessLevel.User,
                    OnVacation = false
                }
            );
            ReposRekap.Add(
                new RekapClass("Joko Anwar")
                {
                    KodeUnit = 11,
                    NoAgenda = 135,
                    Address = "Ngaliyan, Semarang",
                    JP = "PB",

                    BirthDate = new DateTime(1955, 3, 4),
                    HireDate = new DateTime(1993, 10, 17),
                    Position = "Sales Manager",
                    Phone = "(71) 555-4848",
                    Access = AccessLevel.User,
                    OnVacation = true
                }
            );
            ReposRekap.Add(
                new RekapClass("Bambang")
                {
                    KodeUnit = 12,
                    NoAgenda = 136,
                    Address = "Genuk, Semarang",
                    JP = "PB",

                    BirthDate = new DateTime(1981, 7, 2),
                    HireDate = new DateTime(1999, 10, 17),
                    Position = "Sales Representative",
                    Phone = "(71) 555-7773",
                    Access = AccessLevel.User,
                    OnVacation = false
                }
            );
            ReposRekap.Add(
                new RekapClass("Robert King")
                {
                    KodeUnit = 13,
                    NoAgenda = 137,
                    Address = "Sampangan, Semarang",
                    JP = "PB",

                    BirthDate = new DateTime(1960, 5, 29),
                    HireDate = new DateTime(1994, 1, 2),
                    Position = "Sales Representative",
                    Phone = "(71) 555-5598",
                    Access = AccessLevel.User,
                    OnVacation = false
                }
            );
            ReposRekap.Add(
                new RekapClass("Laura Callahan")
                {
                    KodeUnit = 12,
                    NoAgenda = 138,
                    Address = "Sampangan, Semarang",
                    JP = "PB",

                    BirthDate = new DateTime(1985, 1, 9),
                    HireDate = new DateTime(2004, 3, 5),
                    Position = "Inside Sales Coordinator",
                    Phone = "(206) 555-1189",
                    Access = AccessLevel.User,
                    OnVacation = true
                }
            );
            ReposRekap.Add(
                new RekapClass("Anne Dodsworth")
                {
                    KodeUnit = 13,
                    NoAgenda = 139,
                    Address = "Jatingaleh, Semarang",
                    JP = "PB",

                    BirthDate = new DateTime(1980, 1, 27),
                    HireDate = new DateTime(2004, 11, 15),
                    Position = "Sales Representative",
                    Phone = "(71) 555-4444",
                    Access = AccessLevel.User,
                    OnVacation = false
                }
            );
        }
    }
}
