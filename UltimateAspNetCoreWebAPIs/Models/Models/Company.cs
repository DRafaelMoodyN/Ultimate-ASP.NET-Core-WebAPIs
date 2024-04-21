namespace Models {
    public class Company {

        [Column("CompanyID")]
        public Guid CompanyID { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        [MaxLength(100, ErrorMessage = "Maximo de caracteres 100")]
        public string Name { get; set; }

        [Required(ErrorMessage = "la dirrecion es requerdida")]
        [MaxLength(100, ErrorMessage = "Maximo de caracteres 100")]
        public string Address { get; set; }

        // 

        public ICollection<Employee>? Employee { get; set; }
    }
}