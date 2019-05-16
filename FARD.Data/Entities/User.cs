using System;
namespace FARD.Data.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public String Username { get; set; }
        public String Email { get; set; }
        public Boolean EmailConfirmed { get; set; }
        public String Password { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid CreatedByUserId { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid? ModifiedByUserId { get; set; }
    }
}
