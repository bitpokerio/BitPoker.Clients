using System;
using System.Threading.Tasks;
using Xunit;

namespace BitPoker.Clients.Core.xUnitTests
{
    public class ClientTests
    {
        [Fact]
        public async Task Should_Get_Balance()
        {
            IBalanceClient client = new BitPoker.Clients.QBit(true);
            var actual = await client.GetBalanceAsync("msPJhg9GPzMN6twknwmSQvrUKZbZnk51Tv", 1);
            
            Assert.True(actual > 0);
        }
    }
}