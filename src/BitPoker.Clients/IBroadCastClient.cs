using System;
using System.Threading.Tasks;

namespace BitPoker.Clients
{
    public interface IBroadCastClient
    {
        String Submit(String tx);
        
        Task<String> SubmitAsync(String tx);
    }
}