namespace _23._04._2024.Models
{
    internal class Person
    {
        public string _name { get; set; }
        public string _surname { get; set; }
        public int _age { get; set; }


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }
        public int Age
        { 
            get { return _age; }
            set {  _age = value; } 
        }
        public Person(string name,string surname,int age)
        {
            Name=name;
            Surname=surname;
            Age=age;
        }



    }
}
