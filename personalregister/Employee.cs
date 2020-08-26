namespace personalregister
{
    class Employee
    {
        public string Name { get; set; }
        public float Salary { get; set; }

        public override string ToString()
        {
            return "Namn: " + Name + System.Environment.NewLine  + "Lön:  " + Salary.ToString();
        }

    }
}
