namespace University
{
    public struct Address
    {
        public string Country;
        public string City;
        public string Street;
        public string BuildingNum;

        public Address(string country, string city, string street, string buildingNum)
        {
            Country = country;
            City = city;
            Street = street;
            BuildingNum = buildingNum;
        }

        public override string ToString()
        {
            return $"{Country} {City} {Street}, {BuildingNum}";
        }

    }
}
