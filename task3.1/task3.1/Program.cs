using task3._1;

Students[] students = new Students[5];
float sum = 0;
float avg = 0;
for (int i = 0; i < students.Length; i++)
{
    Console.WriteLine("Enter the student name ");
    String name = Console.ReadLine();
    Console.WriteLine("Enter the student grade");
    float grade = float.Parse(Console.ReadLine());
    students[i] = new Students(name, grade);
    sum += grade;
}
avg = sum / students.Length;
int numberOfStudent = 0;
foreach (var student in students)
{
    if (student.avg > avg)
    {
        Console.WriteLine(student.name);
    }
}

