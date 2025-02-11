namespace University
{
    public class Person
    {
        public string Name { get; }
        public int Age { get; }
        public Address Address { get; }
        public bool hasAddress = false;


        public Person(string name, int age, Address address)
        {

            Name = name;
            Age = age;
            Address = address;

            hasAddress = true;
        }
        public Person(string name, int age)
        {

            Name = name;
            Age = age;
        }

        public virtual void ShowInformation()
        {
            if (hasAddress == true)
                Console.WriteLine($"name: {Name} \nage: {Age} \nAddress: {Address}");
            else
                Console.WriteLine($"name: {Name} \nage: {Age}");

        }

    }
}
