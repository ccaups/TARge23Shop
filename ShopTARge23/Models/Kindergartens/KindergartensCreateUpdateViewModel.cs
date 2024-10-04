namespace ShopTARge23.Models.Kindergartens
{
    public class KindergartensCreateUpdateViewModel
    {
        public Guid? Id { get; set; }
        public string GroupName { get; set; }
        public int ChildrenCount { get; set; }
        public string KindergartenName { get; set; }
        public String Teacher { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public List<string> KindergartenNames { get; set; }
        public List<string> GroupNames { get; set; }
        public List<string> TeacherNames { get; set; }
    }
}
