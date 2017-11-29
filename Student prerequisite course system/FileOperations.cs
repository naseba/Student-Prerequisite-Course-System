using System;
using System.IO;

static public class FileOperations
{
    static public class UsersFile
    {
        static public void WriteUser(Student s)
        {
            throw new NotImplementedException();
        }
        static public bool CheckUser(Student s)
        {
            throw new NotImplementedException();
        }
    }
    static public class AdminFile
    {
        static public void WriteAdmin(Admin s)
        {
            throw new NotImplementedException();
        }
        static public void CheckAdmin(Admin s)
        {
            throw new NotImplementedException();
        }
    }
    static public class TreeFile
    {
        //Delayed till tree is done
    }
    static public class Users_SubjectsFile
    {
        static public void UpdateUser(Student s, Course c)
        {
            throw new NotImplementedException();
        }
        static public Course[] GetSubjects(Student s)
        {
            throw new NotImplementedException();
        }
    }
    static public class Subjects_UsersFile
    {
        static public void UpdateSubject(Course c, Student s)
        {
            throw new NotImplementedException();
        }
        static public Student[] GetStudents(Course c)
        {
            throw new NotImplementedException();
        }
    }
}
