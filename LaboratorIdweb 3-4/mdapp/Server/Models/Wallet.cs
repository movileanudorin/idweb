using System;

namespace BlazorApp3.Server.Models
{
    public class Wallet
    {
        public Guid Id { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public string ApplicationUserId { get; set; }
    }
}
