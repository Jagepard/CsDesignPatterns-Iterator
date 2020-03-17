/**
 * @author  : Jagepard <jagepard@yandex.ru>
 * @license https://mit-license.org/ MIT
 */

using System.Collections.Generic;

namespace CsDesignPatterns_Iterator
{
    class Client : IClient
    {
        private readonly List<IItem> bucket = new List<IItem>();

        public void AddItemToTheBucket(IItem item)
        {
            bucket.Add(item);
        }

        public List<IItem> GetBucket()
        {
            return bucket;
        }
    }
}
