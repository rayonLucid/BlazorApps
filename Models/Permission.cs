using System.ComponentModel.DataAnnotations;

namespace Club_Portal.Models
{
    public class Permission
    {
        [Key]
        public string UserID { get; set; }
        public bool CanEdit { get; set; }
        public bool CanModify { get; set; }
        public bool CanCreate { get; set; }
    }
}