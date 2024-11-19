using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Nhanlene.Program;

namespace Nhanlene
{
    internal class Program
    {

        public class Student
        {
            private int id;
            private string name;
            private int age;
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public Student() { }
            public Student(int id, string name, int age)
            {

                this.id = id;
                this.name = name;
                this.age = age;
            }
            public void input()
            {
                Console.Write("Mời bạn nhập mã: ");
                id = int.Parse(Console.ReadLine());
                Console.Write("Mời bạn nhập tên: ");
                name = Console.ReadLine();
                Console.Write("Mời bạn nhập tuổi: ");
                age = int.Parse(Console.ReadLine());
            }

            //public void output()
            //{
            //    Console.WriteLine($"Mã: {id}");
            //    Console.WriteLine($"Tên: {name}");
            //    Console.WriteLine($"Tuổi: {age}");
            //}
            static void Main(string[] args)
            {
                List<Student> list = new List<Student>{
                 new Student { Id = 1, Name = "A", Age = 16 },
                 new Student { Id = 2, Name = "B", Age = 18 },
                 new Student { Id = 3, Name = "C", Age = 20 },
                 new Student { Id = 4, Name = "D", Age = 15 },
                 new Student { Id = 5, Name = "Nhan", Age = 17 }
                 };


                while (true)
                {
                    Console.WriteLine("\nMenu:");
                    Console.WriteLine("1: Nhập thêm 1 sinh viên");
                    Console.WriteLine("2: In ra danh sách toàn bộ học sinh");
                    Console.WriteLine("3: Tìm và in ra danh sách các học sinh có tuổi từ 15 đến 18");
                    Console.WriteLine("4: Tìm và in ra danh sách học sinh có tên bắt đầu bằng chữ 'A'");
                    Console.WriteLine("5: Tính tổng số tuổi học sinh trong danh sách");
                    Console.WriteLine("6: Tim và in ra học sinh có tuổi lớn nhất");
                    Console.WriteLine("7: Sap xep");
                    Console.WriteLine("0: Thoát");
                    Console.Write("Chọn chức năng: ");
                    int n = int.Parse(Console.ReadLine());

                    switch (n)
                    {
                        case 1:
                            Student st = new Student();
                            st.input();
                            list.Add(st);
                            break;

                        case 2:
                            Console.WriteLine("Danh sách học sinh:");
                            list.ForEach(s => Console.WriteLine($"Id: {s.Id}, Name: {s.Name}, Age: {s.Age}"));
                            break;

                        case 3:
                            var aS = list.Where(s => s.Age >= 15 && s.Age <= 18).ToList();
                            Console.WriteLine("Học sinh từ 15 đến 18 tuổi:");
                            aS.ForEach(s => Console.WriteLine($"Id: {s.Id}, Name: {s.Name}, Age: {s.Age}"));

                            break;

                        case 4:
                            try
                            {
                                var nameA = list.Where(s => s.Name.StartsWith("A")).ToList();
                                Console.WriteLine("Học sinh có tên bắt đầu bằng chữ 'A':");
                                nameA.ForEach(s => Console.WriteLine($"Id: {s.Id}, Name: {s.Name}, Age: {s.Age}"));
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Khong co ");
                            }
                            break;

                        case 5:
                            int sumA = list.Sum(s => s.Age);
                            Console.WriteLine($"Tổng tuổi của học sinh: {sumA}");
                            break;
                        case 6:
                            var hs = list.OrderByDescending(s => s.Age).First();
                            Console.WriteLine($"Học sinh có tuổi lớn nhất: Id: {hs.Id}, Name: {hs.Name}, Age: {hs.Age}");
                            break;
                        case 7:
                            var sx = list.OrderBy(s => s.Age).ToList();
                            Console.WriteLine("Danh sách sau khi sắp xếp theo tuổi tăng dần:");
                            sx.ForEach(s => Console.WriteLine($"Id: {s.Id}, Name: {s.Name}, Age: {s.Age}"));
                            break;

                        case 0:
                            Console.WriteLine("Thoát chương trình.");
                            return;

                        default:
                            Console.WriteLine("Chức năng không hợp lệ. Vui lòng chọn lại.");
                            break;
                    }
                }

            }

        }



    }
}
