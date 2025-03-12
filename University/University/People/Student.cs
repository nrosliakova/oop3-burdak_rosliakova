namespace University
{
    public partial class Student : Person
    {
        private static int counter = 0;
        public static int Counter
        {
            get
            {
                return counter;
            }
        }

        public long StudentID { get; }
        public float StudentGPA { get; }

        //public Student()
        //{

        //}

        public Student(long id, string name, int age, float gpa, Address address)
            : base(name, age, address)
        {

            StudentID = id;
            StudentGPA = gpa;

            counter++;
            hasAddress = true;

        }
        public Student(long id, string name, int age, float gpa)
            : base(name, age)
        {

            StudentID = id;
            StudentGPA = gpa;

            counter++;

        }

        public new void ShowInformation()
        {
            if (hasAddress == true)
                Console.WriteLine($"Student #{StudentID}: \n\tname: {Name} \n\tage: {Age}\n\tGPA: {StudentGPA} \n\tAddress: {Address}");
            else
                Console.WriteLine($"Student #{StudentID}: \n\tname: {Name} \n\tage: {Age}\n\tGPA: {StudentGPA}");

        }

        ~Student()
        {
            Console.WriteLine($"Student #{StudentID} ({Name}) was expelled.");
        }

    }

}
