using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupposedlySecureApplication.Data
{
    public class CreditCard
    {
        public string num { get; set; }
        public int cvv { get; set; }
        public int expMon { get; set; }
        public int expYr { get; set; }
        public string billingAddr { get; set; }
        [Key]
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }
    }
}