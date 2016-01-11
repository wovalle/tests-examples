using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test.Project.Library
{
    public class Citizen
    {
        const int AGE_TO_BECOME_ADULT = 18;

        public Guid Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }
        
        private string _Document_Number;

        public string Document_Number {
            get { return _Document_Number; }
            set {
                float number;

                if (String.IsNullOrEmpty(value))
                    throw new Exception("Invalid blank document number");
                else if (value.Length > 11)
                    throw new Exception("Document number cannot have more than 11 characters");
                else if (value.Length < 11)
                    throw new Exception("Document number cannot have less than 11 characters");
                else if (!float.TryParse(value, out number))
                    throw new Exception("Invalid document number.");

                _Document_Number = value;
            }
        }

        public char _Sex;

        public char Sex { 
            get {return _Sex; } 
            set { 
                if(value != 'M' && value != 'F')
                    throw new Exception("Invalid Sex");

                _Sex = value;
            } 
        }

        public DateTime BirthDate { get; set; }

        public bool Save()
        {
            /*Emulate database call*/
            this.Id = Guid.NewGuid();
            return true;
        }

        public int Age()
        {
            var today = DateTime.Now;
            int age = today.Year - this.BirthDate.Year;
            return this.BirthDate > today.AddYears(-age) ? age : age--;
        }

        public bool IsAdult()
        {
            return this.Age() >= AGE_TO_BECOME_ADULT;
        }

        public enum SexType { 
            Male = 'M', 
            Female = 'F'
        }
    }
}
