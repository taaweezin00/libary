using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StudentClassLibrary
{

    public class StudentController
    {
        List<Student> listStudent = new List<Student>();
        public void addStudent2List(string id, string name) {
            string full = (id + name);
            return;
        
        }
        public void addStudent2List(Student student) { 
            listStudent.Add(student);
            this.addStudent2List(student);
                //return student_id + "," + name;
            }
        public string displayData() {
            return "1111";
        }
        public void saveFile() {
        }
        public void openFile() { 
        }

    }
}
