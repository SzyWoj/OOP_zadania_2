using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace OOP
{
    class Program
    {
        class Student
        {
            private string imie;
            private int wiek;
            private string kierunek;
            private bool urlop;

            //Constructor
            public Student(string imie, int wiek, string kierunek, bool urlop = false)
            {
                this.imie = imie;
                this.wiek = wiek;
                this.kierunek = kierunek;
                this.urlop = urlop;
            }

            //get and set methods
            public string Imie { get { return imie; } }
            public int Wiek { get { return wiek; } }
            public string Kierunek { get { return kierunek; } }
            public bool Urlop { get { return urlop; } }

            public void wezUrlop()
            {
                urlop = true;
            }

            public string Statut()
            {
                if (urlop)
                    return "Student jest na urlopie dziekańskim";
                else
                    return "Student studiuje";
            }

            public override string ToString()
            {
                return $"Imię: {imie}, Wiek: {wiek}, Kierunek: {kierunek}, Urlop: {urlop}";
            }
        }

        static void Main(string[] args)
        {
            //Creating object
            Student student = new Student("Szymon", 24, "Informatyka");

            Console.WriteLine(student);
            Console.WriteLine(student.Statut());

            student.wezUrlop();
            Console.WriteLine(student.Statut());
        }
    }
}
