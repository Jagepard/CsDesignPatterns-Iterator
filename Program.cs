/**
 * @author  : Jagepard <jagepard@yandex.ru>
 * @license https://mit-license.org/ MIT
 */

using System;

namespace CsDesignPatterns_Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            IClient client = new Client();

            client.AddItemToTheBucket(new Item("Колготки", 150, "штопаные"));
            client.AddItemToTheBucket(new Item("Мясо", 250, "тухлое"));
            client.AddItemToTheBucket(new Item("Батон", 40, ""));

            IIterator employee = new Iterator(client.GetBucket());

            try
            {
                employee.IterateItems();
            }
            catch (Exception e)
            {
                Console.WriteLine("Caught exception: {0} \n", e.Message);
            }
        }
    }
}
