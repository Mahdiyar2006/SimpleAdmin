
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using VideoShop.Core.Domains;

public class Utils
{
    public enum ActiveItem
    {
        Dashboard,
        Users,
        UserRoles,
        Teachers,
        Courses,
        CategoryCourses,
        Tickets,
    }

    public enum ActivateSearch
    {
        Yes,
        No,
    }

    public const string IndexName = "Index";

    public const string ImageDirPath = @"~\img\";

    public const string ImageExtention = ".png";

    public const string AdminUserRole = "1";

    public const string UserRoleName = "UserRole";

    public static void CreateDirectory()
    {
        if (!Directory.Exists(ImageDirPath))
        {
            Directory.CreateDirectory(ImageDirPath);
        }
    }
    public static void CopyImage(IFormFile file, int Id)
    {
        CreateDirectory();
        var stream = new FileStream(ImageDirPath + Id + ImageExtention, FileMode.Create);
        file.CopyTo(stream);
    }
    public static AppUser GetUser(string username
            , string name
            , string lastname
            , string password)
    {
        AppUser user = new AppUser();

        user.UserName = username;

        user.FirstName = name;

        user.LastName = lastname;

        user.Password = EncryptionHelper.GetSha256Hash(password);

        return user;
    }

    public static AppUser GetUser(int id
            , string username
            , string name
            , string lastname
            , string password)
    {
        AppUser user = new AppUser();

        user.Id = id;

        user.UserName = username;

        user.FirstName = name;

        user.LastName = lastname;

        user.Password = EncryptionHelper.GetSha256Hash(password);

        return user;
    }

    public static CategoryCourse GetCategoryCourse(string title)
    {
        CategoryCourse entity = new CategoryCourse();

        entity.Title = title;

        return entity;
    }

    public static CategoryCourse GetCategoryCourse(int Id, string title)
    {
        CategoryCourse entity = new CategoryCourse();

        entity.Id = Id;

        entity.Title = title;

        return entity;
    }

    public static Course GetCourse(int Id,
        string name,
        string subject,
        string content,
        int ccId,
        int tId)
    {
        Course entity = new Course();

        entity.Id = Id;

        entity.TeacherId = tId;

        entity.CategoryCourseId = ccId;

        entity.Content = content;

        entity.CourseName = name;

        entity.CourseSubject = subject;

        return entity;
    }

    public static Course GetCourse(
        string name,
        string subject,
        string content,
        int ccId,
        int tId)
    {
        Course entity = new Course();

        entity.TeacherId = tId;

        entity.CategoryCourseId = ccId;

        entity.Content = content;

        entity.CourseName = name;

        entity.CourseSubject = subject;

        return entity;
    }

    public static Teacher GetTeacher(
        int id, string name, int age, string address)
    {
        Teacher entity = new Teacher();

        entity.Id = id;

        entity.Name = name;

        entity.Age = age;

        entity.Address = address;

        return entity;
    }

    public static Teacher GetTeacher(
        string name, int age, string address)
    {
        Teacher entity = new Teacher();

        entity.Name = name;

        entity.Age = age;

        entity.Address = address;

        return entity;
    }

    public static SelectCourse GetSelectCourse(int courseId, int userId)
    {
        SelectCourse entity = new SelectCourse();

        entity.CourseId = courseId;

        entity.AppUserId = userId;

        return entity;
    }

    public static SelectCourse GetSelectCourse(int Id, int courseId, int userId)
    {
        SelectCourse entity = new SelectCourse();

        entity.Id = Id;

        entity.CourseId = courseId;

        entity.AppUserId = userId;

        return entity;
    }


}