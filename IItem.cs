/**
 * @author  : Jagepard <jagepard@yandex.ru>
 * @license https://mit-license.org/ MIT
 */

namespace CsDesignPatterns_Iterator
{
    interface IItem
    {
        string GetDescription();
        string GetName();
        int GetPrice();
    }
}
