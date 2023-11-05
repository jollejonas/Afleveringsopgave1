namespace Afleveringsopgave.Models
{
    public static class Repository
    {
        private static List<ShoppingList> shoppingListItems = new();
        private static int nextID = 1;
        public static IEnumerable<ShoppingList> ShoppingListItems => shoppingListItems;
        public static void AddToShoppingList(ShoppingList shoppingList)
        {
            Console.WriteLine(shoppingList);
            shoppingList.Id = nextID++;
            shoppingListItems.Add(shoppingList);
        }

        public static void RemoveItem(int itemId)
        {
            var itemToRemove = shoppingListItems.First(item => item.Id == itemId);
            if (itemToRemove != null)
            {
                shoppingListItems.Remove(itemToRemove);
            }
        }
    }
}
