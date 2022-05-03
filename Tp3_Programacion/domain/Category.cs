namespace domain
{
    public class Category
    {
        public int IdCategory { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return Description;
        }
    }
}
