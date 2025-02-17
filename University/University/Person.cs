namespace University
{
    public abstract class Person
    {
        public string Name { get; }
        public int Age { get; }
        public Address? Address { get; }
        public bool hasAddress = false;


        public Person()
        {

            Name = "Unknown";
            //Age = age;
        }
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
        public Person(string name)
        {

            Name = name;
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
