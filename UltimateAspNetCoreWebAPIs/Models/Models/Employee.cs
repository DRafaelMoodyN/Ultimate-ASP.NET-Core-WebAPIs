
namespace Models {
    public class Employee {

        [Column("EmployeeID")]
        public int EmployeeID {  get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        [MaxLength(100, ErrorMessage = "Maximo de caracteres 100")]
        public string FirstName { get; set; } = String.Empty;

        [Required(ErrorMessage = "El nombre es requerido")]
        [MaxLength(100, ErrorMessage = "Maximo de caracteres 100")]
        public string LastName { get; set; } = String.Empty;

        [ForeignKey(nameof(Company))]
        public Guid CompanyID { get; set; } 
        public Company Company { get; set; }
    }
}
