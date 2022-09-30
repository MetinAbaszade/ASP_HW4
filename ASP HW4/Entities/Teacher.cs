namespace ASP_HW4.Entities
{
    public class Teacher
    {
        public Teacher()
        {
                    
        }

        public Teacher(int ıd, string name, string surname, int age, string address, int salary)
        {
            Id = ıd;
            Name = name;
            Surname = surname;
            Age = age;
            Address = address;
            Salary = salary;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public int Salary { get; set; }
    }
}
