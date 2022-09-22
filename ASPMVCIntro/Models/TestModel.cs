using System.ComponentModel.DataAnnotations;

namespace ASPMVCIntro.Models
{
    public class TestModel
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Opa..")]
        public string Product { get; set; }
    }
}
