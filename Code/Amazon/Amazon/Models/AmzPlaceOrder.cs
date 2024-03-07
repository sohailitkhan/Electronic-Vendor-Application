using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Amazon.Models
{
    [Table("AMZ_PLACE_ORDER")]
    public partial class AmzPlaceOrder
    {
        [Key]
        [Column("PO_ID")]
        public int ID { get; set; }
        [Column("PO_USERNAME")]
        public string UserName { get; set; }

        [Column("PO_USEREMAIL")]
        public string Email { get; set; }
        [Column("PO_DATE")]
        public string Date { get; set; }
        [Column("PO_USERADDRESS")]
        public string address { get; set; }

        [Column("PO_USERPHONE")]
        public string phone { get; set; }

        [Column("PO_SHIPMENTID")]
        public int ShipmemtId { get; set; }
    }
}
