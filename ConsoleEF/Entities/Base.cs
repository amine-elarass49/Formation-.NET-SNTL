using System.ComponentModel.DataAnnotations;

namespace ConsoleAppEF.Entities;
public abstract class Base{
        [Key]
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
        
        public int CreateBy { get; set; }
        public int UpdateBy { get; set; }
        public int DeleteBy { get; set; }
        public bool IsDelete { get; set; }
       


}