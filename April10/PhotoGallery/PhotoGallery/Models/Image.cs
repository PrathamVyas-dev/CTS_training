namespace PhotoGallery.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime UploadedAt { get; set; }
        public string Tags { get; set; }
        public string AlternateText { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string Border { get; set; }
        public string Alignment { get; set; }
    }
}
