using System.Threading.Tasks;

namespace BitPoker.Clients
{
    public class Insights : IBalanceClient
    {
        public Task<UInt64> GetBalanceAsync(string address, int confirmations)
        {
            throw new System.NotImplementedException();
        }
    }
}