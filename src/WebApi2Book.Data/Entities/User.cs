namespace WebApi2Book.Data.Entities
{
    public class User : IVersionedEntity
    {
        public virtual long UserId { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Username { get; set; }
        public virtual byte[] Version { get; set; }
    }
}
