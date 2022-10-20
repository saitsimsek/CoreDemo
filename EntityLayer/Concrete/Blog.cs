namespace EntityLayer.Concrete
{
    public class Blog: BaseEntity
    {
        public int Title { get; set; }  
        public string BlogContent { get; set; }
        public string ThumbnailImage { get; set; }
        public string Image { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
