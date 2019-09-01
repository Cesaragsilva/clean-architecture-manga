namespace Manga.Domain.Accounts
{
    using System;
    using Manga.Domain.ValueObjects;

    public class Credit : ICredit
    {
        public Guid Id { get; protected set; }
        public PositiveAmount Amount { get; protected set; }
        public string Description
        {
            get { return "Credit"; }
        }
        public DateTime TransactionDate { get; protected set; }

        public PositiveAmount Sum(PositiveAmount amount)
        {
            return Amount.Add(amount);
        }
    }
}