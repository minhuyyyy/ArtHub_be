﻿using ArtHub.BusinessObject;
using ArtHub.DTO.BalanceDTO;

namespace ArtHub.Repository.Contracts
{
    public interface ITransactionHistoryRepository
    {
        Task<List<HistoryTransaction>> GetHistoryTransactionsByAccountId(int accountId,
            TransactionType? type = null,
            DateTime? fromDate = null,
            DateTime? todate = null);

        Task<HistoryTransaction?> DepositAmountToAccount(TransactionAmount depositAmount, decimal currentBalance);

        Task<HistoryTransaction?> WithdrawAmount(TransactionAmount withdrawAmount, decimal currentBalance);
        Task<HistoryTransaction?> PurchaseAmount(TransactionAmount withdrawAmount, decimal currentBalance, int artworkId);
        Task<HistoryTransaction?> SellAmountToAccount(TransactionAmount depositAmount, decimal currentBalance, int artworkId);
    }
}
