using System;
using System.Collections.Generic;
using System.Text;

namespace StudentClassProject {
    class Student {


        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int FinalGrade { get; set; }

        public string GetFullname() {
           return Firstname + " " + Lastname;
        }
        public void SetFinalGrade(int finalGrade) {
            if(finalGrade < 0) {
                Console.WriteLine("ERROR:  grade must be greater than zero");
            } else {
              FinalGrade = finalGrade;
            }
        }
    }
}
