using System;

namespace BitPoker.Clients.Models.DTOs.QBit
{
    public class Balance
    {
        public Int32 transactionCount { get; set; }

        public UInt64 amount { get; set; }

        public UInt64 received { get; set; }
    }
}