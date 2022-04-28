// See https://aka.ms/new-console-template for more information
using Classes;

/*Console.WriteLine("Hello, World!");

var tomas = new Student() { Name = "Tomas" };
var darius = new Student() { Name = "Darius" };

var matematika = new Course() { Name = "Matematika" };
var braizyba = new Course() { Name = "Braižyba" };


tomas.Courses.Add(matematika);
tomas.Courses.Add(braizyba);

darius.Courses.Add(matematika);

var context = new ClassContex();

context.Students.AddRange(darius, tomas);

context.SaveChanges();*/






































var files = Directory.GetFiles(@"C:\Users\redas.rimkus\source\repos\CodeAcademy\RobotsManagement");
foreach (var item in files)
{
    Console.WriteLine(new FileInfo(item).Length);
    Console.WriteLine(Path.GetFileNameWithoutExtension(item));
}
Console.ReadLine();