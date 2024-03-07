using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Amazon.Models
{
    [Table("AMZ_MANUFACTURER")]
    public partial class AmzManufacturer
    {
        [Key]
        [Column("WAREHOUSE_ID")]
        public int ID { get; set; }
        [Column("WAREHOUSE_NAME")]
        public string WAREHOUSE_NAME { get; set; }

        [Column("WAREHOUSE_LOCATION")]
        public string WAREHOUSE_LOCATION { get; set; }
        [Column("WAREHOUSE_ADDRESS")]
        public string WAREHOUSE_ADDRESS { get; set; }
        [Column("WAREHOUSE_CITY")]
        public string WAREHOUSE_CITY { get; set; }

        [Column("WAREHOUSE_POSTALCODE")]
        public string WAREHOUSE_POSTALCODE { get; set; }
    }
}
