namespace Demo.Assignment5
{
    public class NamePhone
    {
        private string name;
        private string number;

        public NamePhone()
        {
        }

        public NamePhone(string name, string number)
        {
            this.name = name;
            this.number = number;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Number
        {
            get => number;
            set => number = value;
        }
    }
}