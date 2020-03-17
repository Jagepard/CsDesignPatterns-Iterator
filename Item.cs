/**
 * @author  : Jagepard <jagepard@yandex.ru>
 * @license https://mit-license.org/ MIT
 */

namespace CsDesignPatterns_Iterator
{
    internal class Item : IItem
    {
        private string Name { get; }
        private int Price { get; }
        private string Description { get; }

        public Item(string name, int price, string description)
        {
            this.Name = name;
            this.Price = price;
            this.Description = description;
        }

        public string GetName()
        {
            return Name;
        }

        public int GetPrice()
        {
            return Price;
        }

        public string GetDescription()
        {
            return Description;
        }
    }
}