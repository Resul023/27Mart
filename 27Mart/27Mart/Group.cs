using System;
using System.Collections.Generic;
using System.Text;

namespace _27Mart
{
    class Group 
    {

        
        public int No;
        public Student[] students;
        public int StudentLimit;
        public int j = 0;
        
        
        public void AddStudent(Student student)
        {
                students[j++] = student;
            
        }
        public void GetInfo(Student[] students) 
        {
            foreach (var item in students)
            {
                Console.WriteLine($"name-{item.FullName} avgpoint-{item.AvgPoint} groupno-{item.GroupNo}");
            }
        }
        public void GetFiltered(string name) 
        {
            foreach (var item in students)
            {
                if (item.FullName == name)
                {
                    Console.WriteLine($"name-{item.FullName} avgpoint-{item.AvgPoint} groupno-{item.GroupNo}");
                }
            }
        }
        
    }
}
