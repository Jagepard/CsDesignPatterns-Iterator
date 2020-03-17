/**
 * @author  : Jagepard <jagepard@yandex.ru>
 * @license https://mit-license.org/ MIT
 */

using System.Collections.Generic;

namespace CsDesignPatterns_Iterator
{
    interface IClient
    {
        List<IItem> GetBucket();
        void AddItemToTheBucket(IItem item);
    }
}
