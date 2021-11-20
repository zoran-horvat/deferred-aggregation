using System;
using System.Collections.Generic;

namespace CodingHelmet.DeferredAggregation
{
    public interface IAggregatingEnumerable<T, TAcc>
    {
        public TAcc Reduce() =>
            throw new NotImplementedException();

        public TAcc Reduce(Action<IEnumerable<T>> sequenceAction) =>
            throw new NotImplementedException();
    }
}
