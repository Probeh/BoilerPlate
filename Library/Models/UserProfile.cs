using Microsoft.AspNetCore.Identity;
using System;

namespace Library.Models
{
    public class UserProfile : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? ActiveSince { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime? ActiveLast { get; set; }
        public bool IsActive { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Gender { get; set; }

        public UserProfile()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Created = DateTime.Now;
            this.ActiveSince = this.Created;
            this.IsActive = true;
            this.Title = $"User #{this.Id}";
        }

        public UserProfile(string userName) : base(userName) { }
    }
}
