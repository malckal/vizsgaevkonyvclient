using System.Collections.Generic;

namespace yearBookClient.model {
    public class SchoolClass {
        private string className;
        private bool graduation;
        private List<Student> studentList;

        public bool Graduation { get => graduation; set => graduation = value; }
        public string ClassName { get => className; set => className = value; }
        public List<Student> StudentList { get => studentList; set => studentList = value; }

        public SchoolClass() {

        }
    }
}