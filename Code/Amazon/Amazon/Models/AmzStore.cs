using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Amazon.Models
{
    [Table("AMZ_STORE")]
    public partial class AmzStore
    {
        [Key]
        [Column("STORE_ID")]
        public int ID { get; set; }
        [Column("STORE_NAME")]
        public string STORE_NAME { get; set; }

        [Column("STORE_LOCATION")]
        public string STORE_LOCATION { get; set; }
        [Column("STORE_ADDRESS")]
        public string STORE_ADDRESS { get; set; }
        [Column("STORE_CITY")]
        public string STORE_CITY { get; set; }

        [Column("STORE_POSTALCODE")]
        public string STORE_POSTALCODE { get; set; }
    }
}
