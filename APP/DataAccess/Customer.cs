using CORE.Entities;

namespace APP.DataAccess
{
    public class Customer : Entity
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public ICollection<Order> Orders { get; set; }
    }

}
