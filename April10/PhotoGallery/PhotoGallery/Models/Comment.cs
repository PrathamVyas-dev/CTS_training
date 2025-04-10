namespace PhotoGallery.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int ImageId { get; set; }
        public string Text { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Author { get; set; }
        public int Rating { get; set; }
        public int Likes { get; set; }
        public string NestedReply { get; set; }
        public string Formatting { get; set; }
        public string EmojiReaction { get; set; }
    }
}
