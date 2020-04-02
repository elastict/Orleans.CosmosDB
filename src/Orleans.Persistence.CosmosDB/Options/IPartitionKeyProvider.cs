using Orleans.Runtime;
using System.Threading.Tasks;

namespace Orleans.Persistence.CosmosDB.Options
{
    public interface IPartitionKeyProvider
    {
        ValueTask<string> GetPartitionKey(string grainType, GrainReference grainReference, string storageName);
    }

    internal class DefaultPartitionKeyProvider : IPartitionKeyProvider
    {
        public ValueTask<string> GetPartitionKey(string grainType, GrainReference grainReference, string storageName)
        {
            return new ValueTask<string>(grainType);
        }
    }
}
