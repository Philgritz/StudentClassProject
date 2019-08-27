using System;

namespace StudentClassProject {
    class Program {
        static void Main(string[] args) {

            var Lidya = new Student();
            Lidya.Firstname = "Lidya";
            Lidya.Lastname = "Tsegay";
            Lidya.SetFinalGrade(99);
            var fullname = Lidya.GetFullname();
            Console.WriteLine("Lidya's full name is " + fullname);

            var Justin = new Student();
            Justin.Firstname = "Justin";
            Justin.Lastname = "Dudley";
            Justin.SetFinalGrade(98); 
            fullname = Justin.GetFullname();
            Console.WriteLine($"{fullname}");

            var Nick = new Student();
            Nick.Firstname = "Nick";
            Nick.Lastname = "Baker";
            Nick.SetFinalGrade(-100);
            Console.WriteLine($"{Nick.Firstname} {Nick.Lastname}");
        }
    }
}
