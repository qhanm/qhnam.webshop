using qhn.Data.Entity.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace qhn.Data.Entity.Entities
{
    [Table("ContactDetails")]
    public class Contact : EntityId<string>
    {
        public Contact()
        {
        }

        public Contact(string name, string phone, string email, string website, string address, string other, double? longtitude, double? latitude, Status status)
        {
            Name = name;
            Phone = phone;
            Email = email;
            Website = website;
            Address = address;
            Other = other;
            Lng = longtitude;
            Lat = latitude;
            Status = status;
        }

        [StringLength(250)]
        [Required]
        public string Name { set; get; }

        [StringLength(50)]
        public string Phone { set; get; }

        [StringLength(250)]
        public string Email { set; get; }

        [StringLength(250)]
        public string Website { set; get; }

        [StringLength(250)]
        public string Address { set; get; }

        public string Other { set; get; }

        public double? Lat { set; get; }

        public double? Lng { set; get; }

        public Status Status { set; get; }
    }
}