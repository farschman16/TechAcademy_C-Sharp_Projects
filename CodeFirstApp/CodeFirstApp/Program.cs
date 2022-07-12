// See https://aka.ms/new-console-template for more information
using CodeFirstApp;

using (var ctx = new SchoolContext())
{
    var stud = new Student() { StudentName = "James Webb" };

    ctx.Students.Add(stud);
    ctx.SaveChanges();
}
