namespace OneLinkCompany.Models
{
    public class Area
    {
        public int AreaID { get; set; }
        public int SubareaID { get; set; }
        public int EmployeeID { get; set; }
        public string Name { get; set; }

        public Subarea Subarea { get; set; }
        public Employee Employee { get; set; }
    }
}