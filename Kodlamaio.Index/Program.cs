using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;

internal class Program
{

    public static void Main(string[] args)
    {
        ICourseService _course;

        Console.WriteLine("HoşGeldin!\n");

        Console.WriteLine("Kurs Eklemek İster Misin? e/y");

        string answer=Console.ReadLine();

        if (answer == "e")
        {
            _course = AddCourse();
            GetList(_course);
        }

        Console.ReadLine();

    }

    private static void GetList(ICourseService _course)
    {
        List<Course> _courses = new List<Course>();
        _courses = _course.GetAll();
        foreach (var course in _courses)
        {
            Console.WriteLine(course.CourseName);
        }
    }

    private static ICourseService AddCourse()
    {
        ICourseService _course = new CourseManager(new courseDal());
        Console.WriteLine("Kurs ID Giriniz : ");
        string _courseId = Console.ReadLine();

        Console.WriteLine("Kurs Adını Giriniz : ");
        string _courseName = Console.ReadLine();

        Console.WriteLine("Kurs Tanımını Giriniz : ");
        string _courseDescription = Console.ReadLine();

        Console.WriteLine("Kurs Öğretmen Numarasını Giriniz : ");
        string _instructorId = Console.ReadLine();

        Console.WriteLine("Kurs Kategori Numarasını Giriniz : ");
        string _categoryId = Console.ReadLine();

        _course.Add(new Course
        {
            CourseId = _courseId,
            CourseName = _courseName,
            CourseDescription = _courseDescription,
            InstructorId = _instructorId,
            CategoryId = _categoryId
        });
        return _course;
    }
}