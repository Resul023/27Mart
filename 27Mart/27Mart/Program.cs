using System;

namespace _27Mart
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("How many student do you want?");
            int studentLimit = Convert.ToInt32(Console.ReadLine());
            while (studentLimit <= 0 || studentLimit >= 20)
            {

                 studentLimit = Convert.ToInt32(Console.ReadLine());

            }
            bool check = true;
            Console.WriteLine("Write No:");
            string No = Console.ReadLine();
            while (!(char.IsUpper(No[0]) == true && char.IsUpper(No[1]) == true && char.IsDigit(No[2]) == true && char.IsDigit(No[3]) == true && char.IsDigit(No[4]) == true))
            {
                Console.WriteLine("You have to write Two letters and Three numbers");
                No = Console.ReadLine();
            }
            Group studentGroup = new Group();
            studentGroup.students = new Student[studentLimit];
            bool checkTwo = true;
            while (checkTwo)
            {
                Console.WriteLine("1-Add student 2-Look at all of the students 3-Search student 0-End of process ");
                int answer = Convert.ToInt32(Console.ReadLine());
                if (answer == 1   )
                {
                    if (1 + studentGroup.j <= studentLimit)
                    {

                    
                    Array.Resize(ref studentGroup.students, studentLimit);
                    Console.WriteLine("Write name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Write AvgPoint:");
                    int avgpoint = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("write GroupNo:");
                    int groupname = Convert.ToInt32(Console.ReadLine());
                    Student student = new Student(name)
                    {
                        AvgPoint = avgpoint,
                        GroupNo = groupname
                    };
                    studentGroup.AddStudent(student);
                    }
                    else
                    {
                        Console.WriteLine("You break of the limit");

                    }
                }
                else if (answer == 2)
                {
                    Console.WriteLine("nam");
                    Array.Resize(ref studentGroup.students, studentGroup.j);
                    studentGroup.GetInfo(studentGroup.students);
                }

                else if (answer == 3)
                {
                    Array.Resize(ref studentGroup.students, studentGroup.j);
                    Console.WriteLine("Write name for searching:");
                    string nameTool = Console.ReadLine();
                    studentGroup.GetFiltered(nameTool);
                }
                else if (answer == 0) 
                {
                    Console.WriteLine("End of process:");
                    checkTwo = false;
                }
                else
                {
                    Console.WriteLine("You have to write 1,2,3,0 ");
                }


            }
            
           
            

        }
    }
}
