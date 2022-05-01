namespace domain
{
    public class Product
    {
        public string codArticulo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string urlImagen { get; set; }
        public ComercialBrand Marca { get; set; }
        public Category Categoria { get; set; }
        public decimal Precio { get; set; }

    }
}