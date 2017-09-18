using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BitPoker.Clients
{
    public class QBit : BaseClient, IBalanceClient
    {
        public QBit(Boolean testnet = true)
        {
            if (testnet == true)
            {
                _host = "http://tapi.qbit.ninja";
            }
            else
            {
                _host = "http://api.qbit.ninja";
            }
        }

        public async Task<UInt64> GetBalanceAsync(string address, int confirmations)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync(String.Format("{0}/{1}/summary", _host, address))
                {
                    response.EnsureSuccessStatusCode();
                    String json = await response.Content.ReadAsStringAsync();

                    BitPoker.Clients.Models.DTOs.QBit.BalanceSummaryResponse balanceResponse = JsonConvert.DeserializeObject<BitPoker.Clients.Models.DTOs.QBit.BalanceSummaryResponse>(json);
                    return balanceResponse.confirmed.amount;
                }
            }
        }
    }
}