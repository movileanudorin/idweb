using System;

namespace BlazorApp3.Server.Models
{
    public class Transaction
    {
        public Guid Id { get; set; }
        public Guid SourceWalletId { get; set; }
        public Guid DestinationWalletId { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
