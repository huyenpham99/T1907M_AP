using System;
using System.Data.SqlTypes;

namespace Demo.Assignment7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Student s1 = new Student();
            int id, age;
            string address, name;
            double gpa;
            int choose = 0;
            do
          {
              Menu();
              choose = Convert.ToInt32(Console.ReadLine());
              switch (choose)
              {
                  case 1:
                     Console.WriteLine("Nhap ID: ");
                     id = Convert.ToInt32(Console.ReadLine());
                     Console.WriteLine("Nhap ten: ");
                     name = Convert.ToString(Console.ReadLine());
                     Console.WriteLine("Nhap Age: ");
                     age = Convert.ToInt32(Console.ReadLine());
                     Console.WriteLine("Nhap  dia chi: ");
                     address = Convert.ToString(Console.ReadLine());
                     Console.WriteLine("Nhap Gpa: ");
                     gpa = Convert.ToDouble(Console.ReadLine());
                     s1.AddStudent(new Student(id, name, age, address, gpa));
                     s1.ShowStudent();
                     break;
                  case 2:
                      s1.UpdateStudent();
                      break;
                  case 3:
                      s1.RemoveStudent();
                      break;
                  case 4:
                      s1.SortGPA();
                      break;
                      case 5: 
                          s1.SortName();
                          break;
                      case 6:
                         s1.ShowStudent();
                          break;
                          default:
                              Console.WriteLine("Khong co lua chon mowi nhap lai");
                              break;

              }
          } while (choose!=0);
        }

        public static void Menu()
        {
            Console.WriteLine("\n 1. Add student ");
            Console.WriteLine("2. Edit student by id.");
            Console.WriteLine("3. Delete student by id.");
            Console.WriteLine("4. Sort student by gpa.");
            Console.WriteLine("5. Sort student by name.");
            Console.WriteLine("6. Show student");
            Console.WriteLine("Exit");
            Console.WriteLine("Nhap: ");
        }
    }
}