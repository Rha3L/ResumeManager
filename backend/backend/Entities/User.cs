﻿namespace backend.Entities
{
    public class User: BaseEntity
    {
        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        //Relations
        public ICollection<Customer> Companies { get; set; } = new List<Customer>();
    }
}
