namespace CourseApp.Models
{
    
    public class Course
    {
        // Kurslarımızın özelliklerini içerecek şekilde Course adlı bir sınıf oluşturduk.
        // Bu sınıfı action methodlarımızda çağırıp kullanabileceğiz.
        // Daha sonra View ile html sayfamıza gönderip orada kullanabileceğiz.
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsPublished { get; set; }
    }
}