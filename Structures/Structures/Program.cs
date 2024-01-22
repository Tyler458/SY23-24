using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    internal class Program
    {
        struct pokemon
        {
            public int id;
            public string name;
            public int level;

        }
        struct student
        {
            public string name;
            public int age;
            public int grade;
            public gender gender;
            public decimal GPA;
        }

        struct holiday
        {
            public string name;
            public day day;
        }
        enum gender {male,female};
        enum day {mon,tue,wen,thu,fri,sat,sun }
        static void Main(string[] args)
        {
            pokemon pikachu = new pokemon();
            pikachu.name = "Piachu";
            pikachu.level = 1;
            pikachu.id = 1;
            
            student Vonquiqui = new student();
            Vonquiqui.name = "Vonquiqui";
            Vonquiqui.age = 16;
            Vonquiqui.grade = 10;
            Vonquiqui.gender = gender.male;
            Vonquiqui.GPA = 5;

            holiday mlk = new holiday();
            mlk.name = "MLK";
            mlk.day = day.mon;

        }
    }
}
