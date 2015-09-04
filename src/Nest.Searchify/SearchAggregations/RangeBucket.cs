using System.Collections.Generic;
using System.Linq;

namespace Nest.Searchify.SearchAggregations
{
    public class RangeBucket : Bucket<RangeKeyItem>
    {
        public string Type { get { return "Range"; } }
        
        public RangeBucket(IEnumerable<IAggregation> items)
        {
            Items = items.OfType<RangeItem>().Select(x => new RangeKeyItem(x)).ToList();
        }
    }
}