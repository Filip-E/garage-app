namespace garage_app_entities
{
    public class Image
    {
        public int Id { get; set; }
        public string FilePath { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}