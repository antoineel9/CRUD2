using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD2.Data
{
    public class Departments
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DID { get; set; }

        [Display(Name = "Department Name")]
        public string DName { get; set; }

        [Display(Name = "Dept Head")]
        public string DHead { get; set; }



    }
}
