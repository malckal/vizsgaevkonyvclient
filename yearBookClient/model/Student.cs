using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;


namespace yearBookClient.model {
    public class Student {
        private String firstName;
        private String lastName;
        private DateTime birthDate;
        private String picture;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
        public string Picture { get => picture; set => picture = value; }

        public override string ToString() {
            return $"{LastName} {FirstName} {BirthDate.ToShortDateString()}";
        }
    }
}
