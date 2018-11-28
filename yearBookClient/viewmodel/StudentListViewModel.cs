using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using yearBookClient.model;
using yearBookClient.view;

namespace yearBookClient.viewmodel {
    class StudentListViewModel:BaseModel {
        List<Student> studentList;
        SchoolClass schoolClass;
        public StudentListViewModel() {
            schoolClass = MainWindow.SchoolClassResponse;
            studentList = schoolClass.StudentList;
        }

        public List<Student> StudentList { get => studentList; set => studentList = value; }
        public SchoolClass SchoolClass { get => schoolClass; set => schoolClass = value; }
    }
}
