public class Student
{

    public string Name { get; set; }
    public int BirthMonth { get; set; }
    public int BirthDay { get; set; }

    public Student(string name, int birthMonth, int birthDay)
    {
        Name = name;
        BirthMonth = birthMonth;
        BirthDay = birthDay;
    }


    public override string ToString()
    {
        return $"{Name} (Birthday: {BirthMonth}/{BirthDay})";
    }


}
