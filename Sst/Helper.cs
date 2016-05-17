namespace Sst
{
    public static class Helper
    {
        public static void Method1(dynamic userId, dynamic itemId)
        {
            var user = new User
            {
                Id = itemId
            };

            var item = new Item()
            {
                Id = userId
            };
        }
    }
}