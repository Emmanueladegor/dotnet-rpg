using System;
namespace Dotnet_rpg.Models
{
    public class User
    {
        public int Id { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }
    }
}
