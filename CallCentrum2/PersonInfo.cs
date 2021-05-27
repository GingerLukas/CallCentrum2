using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CallCentrum2
{
    public class PersonInfo
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FullName => Name + ' ' + Surname;
        public string Telephone { get; set; }
        public string Region { get; set; }
        public DateTime? DateOfBirth { get; private set; }
        public EGender Gender { get; private set; } = EGender.None;

        public bool IsSocialValid => _socialSecurityNumber != null && Regex.IsMatch(_socialSecurityNumber, "\\d{6}/\\d{4}");
        private string _socialSecurityNumber;
        public string SocialSecurityNumber
        {
            get { return _socialSecurityNumber;}
            set
            {
                _socialSecurityNumber = value;
                if (IsSocialValid)
                {
                    Gender = EGender.Male;
                    int year = int.Parse(value.Substring(0, 2)) + 1900;
                    if (year<1954)
                    {
                        year += 100;
                    }

                    int month = int.Parse(value.Substring(2, 2));
                    if (month>50)
                    {
                        month -= 50;
                        Gender = EGender.Female;
                    }
                    int day = int.Parse(value.Substring(4, 2));
                    DateOfBirth = new DateTime(year, month, day);
                }
                else
                {
                    Gender = EGender.None;
                    DateOfBirth = null;
                }
            }
        }
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
            sb.Append(Region);
            sb.Append(separator);
            sb.Append(Gender);
            sb.Append(separator);
            sb.Append(DateOfBirth);
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

    public enum EGender
    {
        None,
        Male,
        Female
    }
}
