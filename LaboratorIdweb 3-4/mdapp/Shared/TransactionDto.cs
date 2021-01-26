using System;

namespace BlazorApp3.Shared
{
    public class TransactionDto
    {
        public Guid Id { get; set; }
        public Guid SourceWalletId { get; set; }
        public Guid DestinationWalletId { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
