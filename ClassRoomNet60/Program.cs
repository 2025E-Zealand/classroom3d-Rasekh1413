// See https://aka.ms/new-console-template for more information






Student student1 = new Student("Rasekh", 04, 11);
Student student2 = new Student("Elaf", 04, 11);
Student student3 = new Student("Omar", 29, 04);




List<Student> students = new List<Student> { student1, student2, student3 };
foreach (var student in students)
{
    Console.WriteLine(student);
}