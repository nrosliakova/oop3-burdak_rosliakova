﻿using System.Net;

namespace University
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*IEvaluator evaluator = new Evaluator(); 
            var commmem = new CommitteeMember(evaluator, "Joshua","High Manager" );
            ResearchProject1 reproj = new ResearchProject1();
            reproj.Label = "Label of project";
            Console.WriteLine(commmem.GiveFeedback(reproj));

            var project = new ResearchProject("Project1", "Anna", new DateTime(2025, 1, 25), 30000);
            //project.AddExpense(25000);
            project.AddExpense(25000);

            Address address1 = new Address("Ukraine", "Zhytomyr", "Mykhailivska", "25");
            Address address2 = new Address("Ukraine", "Kyiv", "Zhytomyrska", "4");
            Address address3 = new Address("Ukraine", "Kyiv", "Chreschatyk", "36");
            var student1 = new Student(2345678, "Nina", 18, 82.7f, address1);
            var student2 = new Student(8465312, "Vanya", 20, 87f, address2);
            var student3 = new Student(7389569, "Misha", 26, 89.5f);

            student1.ShowInformation();
            student2.ShowInformation();
            student3.ShowInformation();
            Console.WriteLine($"Student count: {Student.Counter}");*/
            List<Teacher> listOfTeachers = new List<Teacher>();
            List<Course> courses = new List<Course>();
            List<Course> coursesGetAll = new List<Course>();
            IRepository<Course> repo = new Repository<Course>(courses);
            Teacher uniTeacher = new Teacher();
            listOfTeachers.Add(uniTeacher);
            Course course1 = new Course("Discrete Math", uniTeacher, "Spring" );
            Course course2 = new Course("Intro to OOP", uniTeacher, "Spring" );
            Course course3 = new Course("Algorithms", uniTeacher, "Summer" );
            
            repo.Add(course1);
            repo.Add(course2);
            repo.Add(course3);
            coursesGetAll = repo.GetAll();
            
            foreach (var course in coursesGetAll)
            {
              Console.WriteLine(course.Name);  
            }

            var courses2 = new CourseService();

            //courses.RemoveCourse("English");


            courses2.AddCourse("Geometry");
            courses2.AddCourse("English");
            courses2.AddCourse("Basics of Math");
            courses2.PrintCourses();

            courses2.RemoveCourse("English");
            //courses.RemoveCourse("a");
            courses2.PrintCourses();


            Address address1 = new Address("Ukraine", "Zhytomyr", "Mykhailivska", "25");
            Address address2 = new Address("Ukraine", "Kyiv", "Zhytomyrska", "4");
            Address address3 = new Address("Ukraine", "Kyiv", "Chreschatyk", "36");
            var student1 = new Student(2345678, "Nina***", 18, 82.7f, address1);
            var student2 = new Student(8465312, "Vanya", 20, 87f, address2);
            var student3 = new Student(7389569, "Misha", 26, 89.5f);
            //var students = new List<Student>();
            //var repo = new Repository(students);
            var students = new Repository<Student>();
            students.Add(student3);
            students.Add(student1);
            students.Add(student2);
            var s = students.GetAll();
            PrintStudentsList(s);
            Console.WriteLine($"number of students: {students.Count()}");
            students.Delete(student2);
            PrintStudentsList(s);
            var sortedStudents = students.SortBy(student => student.StudentGPA).ToList();
            PrintStudentsList(sortedStudents);


            Teacher teacher = new Teacher();
            listOfTeachers.Add(teacher);
            IRepository<Teacher> teachRepo = new Repository<Teacher>(listOfTeachers);
            Console.WriteLine(teachRepo.FindById(2).Name);

            Cultural cultural = new Cultural();
            cultural.GetDateAndTime("en-NZ", "uk-UA");



        }

        public static void PrintStudentsList(List<Student> students)
        {

            Console.WriteLine("STUDENTS");
            foreach (var el in students)
            {
                el.ShowInformation();
            }
        }
    }

}
