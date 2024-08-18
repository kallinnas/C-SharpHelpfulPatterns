namespace C_HelpfulPatterns;

//Дано: Список студентів з оцінками List<(string name, int grade)> students = new List<(string name, int grade)> { ("John", 85), ("Jane", 92), ("Bob", 78), ("Alice", 89) };
//Завдання: Знайдіть студента з найвищою оцінкою.
internal class StudentList
{
    public void Run()
    {
        List<(string name, int grade)> students = new List<(string name, int grade)> { ("John", 85), ("Jane", 92), ("Bob", 78), ("Alice", 89) };

        DisplayHighestMarkStudent(students);

        Console.WriteLine(students.MaxBy(student => student.grade));
    }

    private void DisplayHighestMarkStudent(List<(string name, int grade)> students)
    {
        (string name, int grade)? highestMarkStudent = null;

        try
        {
            for (int i = 0; i < students.Count; i++)
            {
                var student = students[i];

                if (highestMarkStudent == null)
                {
                    highestMarkStudent = student;
                }

                else
                {
                    if (highestMarkStudent.Value.grade < student.grade)
                    {
                        highestMarkStudent = (student);
                    }
                }
            }

            Console.WriteLine("highestMarkStudent: " + highestMarkStudent.Value.name + " " + highestMarkStudent.Value.grade);
        }

        catch (Exception ex)
        {
            Console.Error.WriteLine(ex.ToString());
        }
    }
}
