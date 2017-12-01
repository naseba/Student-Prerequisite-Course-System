
public class Course
{
    public string Name, Description;
    public int TreeIndex;
    Course()
    {
        TreeIndex = -1;
    }
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

public class Pair<F, S>
{
    public F First;
    public S Second;
}