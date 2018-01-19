using BaseEntity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AndersonNotificationEntity
{
    [Table("AndersonNotification")]
    public class ENotification : EBase
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int NotificationId { get; set; }

        [Required]
        [StringLength(100)]
        public string Sender { get; set; }

        [Required]
        [StringLength(100)]
        public string Subject { get; set; }

        [Required]
        [StringLength(10000)]
        public string Body { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Receiver { get; set; }
    }
}