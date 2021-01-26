using BlazorApp3.Server.Models;
using BlazorApp3.Shared;

namespace BlazorApp3.Server.Helpers
{
    public static class DomainMapper
    {
        public static TransactionDto ToDto(Transaction transaction)
        {
            return transaction == null ? null : new TransactionDto
                {
                    Id = transaction.Id,
                    Amount = transaction.Amount,
                    DestinationWalletId = transaction.DestinationWalletId,
                    SourceWalletId = transaction.SourceWalletId,
                    Date = transaction.Date
                };
        }
    }
}
