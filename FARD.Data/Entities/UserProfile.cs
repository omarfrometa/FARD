using System;
namespace FARD.Data.Entities
{
    public class UserProfile
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public DateTime? Birthday { get; set; }
        public String Gender { get; set; }
        public byte?[] Picture { get; set; }
    }
}
