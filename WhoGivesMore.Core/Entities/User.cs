﻿namespace WhoGivesMore.Core.Entities
{
    public class User : BaseEntity
    {
        public User(string fullName,
                    string email,
                    DateTime birthDate,
                    string password,
                    string role)
        {
            FullName = fullName;
            Email = email;
            BirthDate = birthDate;
            CreatedAt = DateTime.Now;
            Active = true;
            Password = password;
            Role = role;


            OwnedItems = new List<Item>();
            ItemsSold = new List<Item>();

            Moves = new List<Move>();
        }

        public string FullName { get; private set; }
        public string Email { get; private set; }
        public DateTime? BirthDate { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public bool Active { get; set; }
        public string Password { get; private set; }
        public string Role { get; private set; }


        public List<Item> OwnedItems { get; private set; }
        public List<Item> ItemsSold { get; set; }
        public List<Move> Moves { get; private set; }


        public void Update(string fullName, string email, DateTime? birthDate)
        {
            FullName = fullName;
            Email = email;
            BirthDate = birthDate;
        }

        public void ChangePassword(string password)
        {
            Password = password;
        }

        public void ChangeRole(string role)
        {
            Role = role;
        }

        public void DisableUser()
        {
            Active = false;
        }
    }
}