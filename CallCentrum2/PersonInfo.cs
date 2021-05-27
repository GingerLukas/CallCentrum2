using System;
using System.Collections.Generic;
using System.Text;

namespace CallCentrum2
{
    public class PersonInfo
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FullName => Name + ' ' + Surname;
        public string Telephone { get; set; }
        public string SocialSecurityNumber { get; set; }
        public Vax FirstDose { get; set; } = new Vax();
        public Vax SecondDose { get; set; } = new Vax();
        public bool HadCovid { get; set; }
        public DateTime CovidDate { get; set; } = DateTime.Now;
        public int Counter { get; set; }

        public string ToString(char separator = ',')
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Name);
            sb.Append(separator);
            sb.Append(Surname);
            sb.Append(separator);
            sb.Append(Telephone);
            sb.Append(separator);
            sb.Append(SocialSecurityNumber);
            sb.Append(separator);
            sb.Append(FirstDose.State);
            sb.Append(separator);
            sb.Append(FirstDose.Time);
            sb.Append(separator);
            sb.Append(SecondDose.State);
            sb.Append(separator);
            sb.Append(SecondDose.Time);
            sb.Append(separator);
            sb.Append(HadCovid);
            sb.Append(separator);
            sb.Append(CovidDate);

            return sb.ToString();
        }
    }

    public class Vax
    {
        public DateTime Time { get; set; } = DateTime.Now;
        public EVaxState State { get; set; }
    }

    public enum EVaxState
    {
        None,
        Registered,
        Done
    }
}
