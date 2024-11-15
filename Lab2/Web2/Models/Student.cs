namespace Web2.Models
{
    //class (Model) name => table name
    public class Student
    {
        //attribute name => column name
        public int Id { get; set; }  //primary key, auto increment
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Avatar { get; set; }
    }
}
