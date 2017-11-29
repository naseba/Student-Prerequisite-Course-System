
public struct Course
{
    public string Name;
}

public struct Student
{
    public string Name, Password;
    public int ID;
    public Course[] RegisteredCourses;
    public bool IsAdmin;
}

public struct Admin
{
    public string Name, Password;
}