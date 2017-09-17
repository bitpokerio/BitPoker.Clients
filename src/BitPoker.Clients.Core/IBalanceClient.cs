using System;
using System.Threading.Tasks;

namespace BitPoker.Clients
{
    /// <summary>
    /// Call a node or web api to get address balance
    /// </summary>
    public interface IBalanceClient
    {
        Task<Int64> GetBalanceAsync(String address, Int32 confirmations);
    }
}