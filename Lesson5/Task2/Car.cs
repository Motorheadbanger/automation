namespace Task2
{
    class Car
    {
        public string Name { get; set; }
        public CarParts[] PartList { get; set; }

        public Car(string name, CarParts[] partList)
        {
            Name = name;
            PartList = partList;
        }
    }
}
