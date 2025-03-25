namespace University
{
    public partial class Student : Person, HasId
    {
        private static int counter = 0;
        public static int Counter
        {
            get
            {
                return counter;
            }
        }

        public int Id { get; }
        public float StudentGPA { get; }

        public Student(int id, string name, int age, float gpa, Address address)
            : base(name, age, address)
        {

            Id = id;
            StudentGPA = gpa;

            counter++;
            hasAddress = true;

        }
        public Student(int id, string name, int age, float gpa)
            : base(name, age)
        {

            Id = id;
            StudentGPA = gpa;

            counter++;

        }

        public new void ShowInformation()
        {
            if (hasAddress == true)
                Console.WriteLine($"Student #{Id}: \n\tname: {Name} \n\tage: {Age}\n\tGPA: {StudentGPA} \n\tAddress: {Address}");
            else
                Console.WriteLine($"Student #{Id}: \n\tname: {Name} \n\tage: {Age}\n\tGPA: {StudentGPA}");

        }

        ~Student()
        {
            Console.WriteLine($"Student #{Id} ({Name}) was expelled.");
        }

    }

}
