/**
 * @author  : Jagepard <jagepard@yandex.ru>
 * @license https://mit-license.org/ MIT
 */

using System;
using System.Collections.Generic;

namespace CsDesignPatterns_Iterator
{
    internal class Iterator : IIterator
    {
        private readonly List<IItem> bucket;

        public Iterator(List<IItem> bucket)
        {
            this.bucket = bucket;
        }

        public void IterateItems()
        {
            foreach (IItem item in this.bucket)
            {
                Console.WriteLine("{0} {1} у.е. {2}", item.GetName(), item.GetPrice(), item.GetDescription());
            }
        }
    }
}