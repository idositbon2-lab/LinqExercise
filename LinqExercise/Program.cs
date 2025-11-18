using LinqExercise.Data;
using LinqExercise.Extentions;
using LinqExercise.Models;
using System.Linq;
namespace LinqExercise
{
    public class Program
    {
        public static List<int> FilterList(List<int> lst, Func<int, bool> condition)
        {
            List<int> result = new List<int>();
            foreach (var item in lst)
            {
                if (condition(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }
        public static int maxBy(List<Student> students, Func<Student, int> param)
        {
            int max = int.MinValue;
            foreach (Student s in students)
            {
                int num = param(s);
                if (num > max)
                    max = num;

            }
            return max;
        }
        static void Main(string[] args)
        {

            Func<int, bool> IsEven = (x) => x % 2 == 0;
            Console.WriteLine(IsEven(5));
            Console.WriteLine(IsEven(4));
            //---------------------------------
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> evens = FilterList(numbers, IsEven);
            List<int> fiveOrMore = FilterList(numbers, x => x >= 5);


            List<Student> students = new List<Student>()
            {
                new Student() { Name = "Alice", Age = 20, grade = 90, ClassName = "Math" },
                new Student() { Name = "Bob", Age = 22, grade = 85, ClassName = "Science" },
                new Student() { Name = "Charlie", Age = 21, grade = 95, ClassName = "Math" },
                new Student() { Name = "David", Age = 23, grade = 80, ClassName = "History" },
                new Student() { Name = "Eve", Age = 20, grade = 88, ClassName = "Science" },
                new Student() { Name = "Frank", Age = 24, grade = 92, ClassName = "Math" },
};

            int maxgrade = maxBy(students,(x) => x.grade);



        } 
        



    }
}

