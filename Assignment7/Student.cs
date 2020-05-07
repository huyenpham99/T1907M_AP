using System;
using System.Collections.Generic;

namespace Demo.Assignment7
{
    public class Student
    {
        private int id;
        private string name;
        private int age;
        private string address;
        private double gpa;
    List<Student>  listStudent = new List<Student>();
    SortByGpa sort = new SortByGpa();
        public Student()
        {
        }

        public Student(int id, string name, int age, string address, double gpa)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.address = address;
            this.gpa = gpa;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Age
        {
            get => age;
            set => age = value;
        }

        public string Address
        {
            get => address;
            set => address = value;
        }

        public double Gpa
        {
            get => gpa;
            set => gpa = value;
        }
        public void AddStudent(Student student)
        {
           listStudent.Add(student);
        }

        public void UpdateStudent()
        {
            string newName, newAddress;
            int newAge;
            double newGpa;
            
            
            Console.WriteLine("Nhap ma sinh vien: " );
            id = Convert.ToInt32(Console.ReadLine());
            foreach (Student p in listStudent)
            {
                if (p.id.Equals(id))
                {
                    Console.WriteLine("Nhap Ten moi: ");
                    newName = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Nhap Tuoi moi: ");
                    newAge = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Nhap Dia chi moi: ");
                    newAddress = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Nhap gpa moi: ");
                    newGpa = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("ID: " + id + "Name: " + newName + " Age: " + newAge +  "Address: " + newAddress +  "GPA: " + newGpa);
                }
            }
        }

        public void RemoveStudent()
        {
            int removeID;
            Console.WriteLine("Nhap ID ma ban muon xoa: ");
            removeID = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < listStudent.Count; i++)
            {
                if (removeID.Equals(listStudent[i].id))
                {
                    listStudent.RemoveAt(i);
                    ShowStudent();
                }
                else
                {
                    Console.WriteLine("\n" +  "ID: " + id + " khong ton tai trong danh sach");
                }
               
            }
        }

        public void SortGPA()
        {
         //  listStudent.Sort(new SortByGpa());
           ShowStudent();
        }

        public void SortName()
        {
            
        }

        public void ShowStudent()
        {
            Console.WriteLine("=====DANH SACH SINH VIEN=====");
            Console.Write("ID: "+ id);
            Console.Write("  | Name: " + name);
            Console.Write("  | Age: " + age);
            Console.Write("  | Address: " + address);
            Console.Write("  | GPA: " + gpa);
        }
    }
}