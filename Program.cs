using System;

namespace ExerBalta.Models.Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Article about OOP.", "object-oriented-programming"));
            articles.Add(new Article("Article about C#.", "csharp"));
            articles.Add(new Article("Article about .Net.", "dotnet"));

            foreach (var article in articles)
            {
                Console.WriteLine(article.Id);
                Console.WriteLine(article.Title);
                Console.WriteLine(article.Url);
            }

            var courses = new List<Course>();
            var courseOOP = new Course("Fundamentals OOP", "fundamentals_oop");
            var courseCsharp = new Course("Fundamentals C#", "fundamentals_csharp");
            var courseAspNet = new Course("Fundamentals Asp.Net", "fundamentals_aspnet");
            courses.Add(courseOOP);
            courses.Add(courseCsharp);
            courses.Add(courseAspNet);

            var careers = new List<Career>();
            var careerDotNet = new Career ("Specialist .Net", "specialist_dotnet");
            var careerItem = new CareerItem(1, "Start here.", "", null);
            careerDotNet.Items.Add(careerItem);
            careers.Add(careerDotNet);

            foreach (var career in careers)
            {   
                Console.WriteLine(career.Title);
                foreach (var item in career.Items)
                {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                }
            }
        }
    }

}