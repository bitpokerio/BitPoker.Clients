using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BitPoker.Clients
{
    /// <summary>
    /// Call a node or web api to get utxo information
    /// </summary>
    public interface IUtxoClient
    {
        IEnumerable<Models.Utxo> GetUtxos(String address);
        
        Task<IEnumerable<Models.Utxo>> GetUtxosAsync(String address);
    }
}