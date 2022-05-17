using System;
using VideoShop.DataLayer;
using VideoShop.Core.Domains;
using VideoShop.Services.Services;

namespace VideoShop.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MainDbContext mainDbContext = new MainDbContext();
            mainDbContext.Database.EnsureCreated();

            Console.WriteLine("Welcome To Sample Department");
            Console.WriteLine("Please Choose your Part");
            Console.WriteLine("1: User | 2: Teacher | 3: Course | 5:Categorycourse |0: Exit");
            int mainKey = int.Parse(Console.ReadLine());

            switch (mainKey)
            {
                case 0:
                    System.Environment.Exit(0);
                    break;
                case 1:
                    StudentsMenu();
                    break;
                case 2:
                    TeacherMenu();
                    break;
                case 3:
                    CourseMenu();
                    break;
                case 5:
                    CategoryCourseMenu();
                    break;

            }
            Console.ReadLine();

            Console.WriteLine("Hello World!");
        }

        public static void StudentsMenu()
        {
            var appService = new AppUserService();
            Console.WriteLine("1: Add | 2: Update | 3: Delete | 0: Exit");
            int studentKey = int.Parse(Console.ReadLine());
            switch (studentKey)
            {
                case 0:
                    System.Environment.Exit(0);
                    break;
                case 1:
                    Console.Write("Enter Name : ");
                    string studentName = Console.ReadLine();
                    Console.Write("Enter LastName : ");
                    string studentlastname = Console.ReadLine();
                    Console.Write("Enter UserName : ");
                    string studentUserName = Console.ReadLine();
                    Console.Write("Enter Password : ");
                    string studentPassword = Console.ReadLine();
                    Console.Write("Enter Role : ");
                    int userRole = int.Parse(Console.ReadLine());
                    var appUser = new AppUser
                    {
                        FirstName = studentName,
                        LastName = studentlastname,
                        UserName = studentUserName,
                        Password = studentPassword,
                    };
                    appService.Add(appUser);
                    break;
                case 2:
                    foreach (var item in appService.GetAll())
                    {
                        Console.WriteLine(item.Id + "\t" + item.FirstName + "\t" + item.LastName);
                    }
                    Console.WriteLine("Enter Your Id");
                    int i2 = int.Parse(Console.ReadLine());
                    Console.Write("Enter Name : ");
                    string studentName2 = Console.ReadLine();
                    Console.Write("Enter LastName : ");
                    string studentlastname2 = Console.ReadLine();
                    Console.Write("Enter UserName : ");
                    string studentUserName2 = Console.ReadLine();
                    Console.Write("Enter Password : ");
                    string studentPassword2 = Console.ReadLine();
                    var appUser2 = new AppUser
                    {
                        Id = i2,
                        FirstName = studentName2,
                        LastName = studentlastname2,
                        UserName = studentUserName2,
                        Password = studentPassword2
                    };
                    appService.Update(appUser2);
                    break;
                case 3:
                    foreach (var item in appService.GetAll())
                    {
                        Console.WriteLine(item.Id + "\t" + item.FirstName + "\t" + item.LastName + "\t" + item.UserName + "\t" + item.Password);
                    }
                    Console.WriteLine("Enter Your Id");
                    int i = int.Parse(Console.ReadLine());
                    try
                    {
                        appService.Delete(i);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }
                    break;
            }
            StudentsMenu();
        }
        public static void TeacherMenu()
        {
            var appService = new TeacherService();
            Console.WriteLine("1: Add | 2: Update | 3: Delete | 0: Exit");
            int teacherKey = int.Parse(Console.ReadLine());
            switch (teacherKey)
            {
                case 0:
                    System.Environment.Exit(0);
                    break;
                case 1:
                    Console.Write("Enter Name : ");
                    string teacherName = Console.ReadLine();

                    Console.Write("Enter Age : ");
                    int teacherAge = int.Parse(Console.ReadLine());

                    var appTeacher = new Teacher
                    {
                        Name = teacherName,
                        Age = teacherAge
                    };
                    appService.Add(appTeacher);
                    break;
                case 2:
                    foreach (var item in appService.GetAll())
                    {
                        Console.WriteLine(item.Id + "\t" + item.Name);
                    }
                    Console.WriteLine("Enter Your Id");
                    int i2 = int.Parse(Console.ReadLine());

                    Console.Write("Enter Name : ");
                    string teacherName2 = Console.ReadLine();

                    Console.Write("Enter Age : ");
                    int teacherAge2 = int.Parse(Console.ReadLine());


                    var appTeacher2 = new Teacher
                    {
                        Id = i2,
                        Name = teacherName2,
                        Age = teacherAge2
                    };
                    appService.Update(appTeacher2);
                    break;
                case 3:
                    foreach (var item in appService.GetAll())
                    {
                        Console.WriteLine(item.Id + "\t" + item.Name);
                    }
                    Console.WriteLine("Enter Your Id");
                    int i = int.Parse(Console.ReadLine());
                    try
                    {
                        appService.Delete(i);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }
                    break;

            }
            TeacherMenu();
        }
        public static void CourseMenu()
        {
            var appService = new CourseService();
            Console.WriteLine("1: Add | 2: Update | 3: Delete | 0: Exit");
            int courseKey = int.Parse(Console.ReadLine());
            switch (courseKey)
            {
                case 0:
                    System.Environment.Exit(0);
                    break;
                case 1:
                    Console.Write("Enter Course Name : ");
                    string CourseName = Console.ReadLine();
                    Console.Write("Enter CourseSubject : ");
                    string CourseSubject = Console.ReadLine();

                    var appCourse = new Course
                    {
                        CourseName = CourseName,
                        CourseSubject = CourseSubject
                    };
                    appService.Add(appCourse);
                    break;
                case 2:
                    foreach (var item in appService.GetAll())
                    {
                        Console.WriteLine(item.Id + "\t" + item.CourseName);
                    }
                    Console.WriteLine("Enter Your Id");
                    int i2 = int.Parse(Console.ReadLine());
                    Console.Write("Enter Course Name : ");
                    string courseName2 = Console.ReadLine();
                    Console.Write("Enter CourseSubject : ");
                    string CourseSubject2 = Console.ReadLine();

                    var appCourse2 = new Course
                    {
                        Id = i2,
                        CourseName = courseName2,
                        CourseSubject = CourseSubject2
                    };
                    appService.Update(appCourse2);
                    break;
                case 3:
                    foreach (var item in appService.GetAll())
                    {
                        Console.WriteLine(item.Id + "\t" + item.CourseName);
                    }
                    Console.WriteLine("Enter Your Id");
                    int i = int.Parse(Console.ReadLine());
                    try
                    {
                        appService.Delete(i);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }
                    break;
            }
            CourseMenu();
        }

        public static void CategoryCourseMenu()
        {
            var appService = new CategoryCourseService();
            Console.WriteLine("1: Add | 2: Update | 3: Delete | 0: Exit");
            int CategorycourseKey = int.Parse(Console.ReadLine());
            switch (CategorycourseKey)
            {
                case 0:
                    System.Environment.Exit(0);
                    break;
                case 1:
                    Console.Write("Enter Title : ");
                    string title = Console.ReadLine();

                    var appCategoryCourse = new CategoryCourse
                    {
                        Title = title
                    };
                    appService.Add(appCategoryCourse);
                    break;
                case 2:
                    foreach (var item in appService.GetAll())
                    {
                        Console.WriteLine(item.Id + "\t" + item.Title);
                    }
                    Console.WriteLine("Enter Your IDCategory");
                    int i2 = int.Parse(Console.ReadLine());
                    Console.Write("Enter Title : ");
                    string title2 = Console.ReadLine();

                    var appTitle = new CategoryCourse
                    {
                        Id = i2,
                        Title = title2
                    };
                    appService.Update(appTitle);
                    break;
                case 3:
                    foreach (var item in appService.GetAll())
                    {
                        Console.WriteLine(item.Id + "\t" + item.Title);
                    }
                    Console.WriteLine("Enter Your IDCategory");
                    int i = int.Parse(Console.ReadLine());
                    try
                    {
                        appService.Delete(i);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }
                    break;
            }
            CategoryCourseMenu();
        }
    }
}
