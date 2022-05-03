namespace domain
{
    public class ComercialBrand
    {
        public int IdComercialBrand { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return Description;
        }
    }
}
