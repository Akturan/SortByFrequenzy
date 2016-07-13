using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortByFrequenzy
{
    public class Sort
    {
        private static Sort _locator;

        private object _lock = new object();

        public Sort sort
        {
            get
            {
                lock (_lock)
                {
                    if(_locator == null)
                        _locator = new Sort();
                }

                return _locator;
            }
        }

        public static IEnumerable<T> byFrequenzy<T>(IEnumerable<T> source, bool descending = true)
        {
            Dictionary<T, int> dict = new Dictionary<T, int>();
            foreach (T item in source)
            {
                if (!dict.ContainsKey(item))
                {
                    dict.Add(item, source.Count(x => x.Equals(item)));
                }
            }
            var orderedItem = descending ? dict.OrderByDescending(x => x.Value) : dict.OrderBy(x => x.Value);
            foreach (var oItem in orderedItem)
            {
                yield return oItem.Key;
            }
        }
    }
}
