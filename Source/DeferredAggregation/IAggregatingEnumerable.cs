using System;
using System.Collections.Generic;

namespace CodingHelmet.DeferredAggregation
{
    public interface IAggregatingEnumerable<T, TAccumulator>
    {
        IEnumerable<T> AsEnumerable();
        IAggregatingEnumerable<TNew, TAccumulator> MapData<TNew>(Func<IEnumerable<T>, IEnumerable<TNew>> map);
        IAggregatingEnumerable<T, TNewAccumulator> MapAccumulator<TNewAccumulator>(Func<TAccumulator, TNewAccumulator> map);
        TAccumulator Reduce();
        TAccumulator Reduce(Action<IEnumerable<T>> sequenceAction);
    }
}
