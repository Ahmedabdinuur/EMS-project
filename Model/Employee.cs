using System.ComponentModel.DataAnnotations;

namespace EMS.Model
{
    internal class Employee
    {
        [Key]
        public int Id { get; set; }
        public int EmployeeId { get; set; } = -1;
        public string Name { get; set; } = "";
        public string address { get; set; } = "";
        public string role { get; set; } = "";
        public string contact { get; set; } = "";
        public double sallery { get; set; } = 0;
        public double serviceyear { get; set; } = 0;
    }

}
