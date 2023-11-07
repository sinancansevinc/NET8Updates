using NET8Updates.API.Models;

namespace NET8Updates.API.Data
{
    public static class FakeUsers
    {
        public static List<User> GetStaticUsers()
        {
            return new List<User>
            {
                new User
                {
                    Id = 1,
                    Email = "kobe@bryant.com",
                    Name = "Kobe Bryant",
                    Username = "kobebryant"
                },
                new User
                {
                    Id = 2,
                    Email = "joel@embiid.com",
                    Name ="Joel Embiid",
                    Username ="embiid"
                },
                new User
                {
                    Id=3,
                    Email="luka@doncic.com",
                    Name ="Luka Doncic",
                    Username="lukadoncic"
                },
                new User
                {
                    Id = 4,
                    Email = "anthony@davis.com",
                    Name ="Anthony Davis",
                    Username ="anthonydavis"
                },
                new User
                {
                    Id = 5,
                    Email ="nikola@jokic.com",
                    Name ="Nikola Jokic",
                    Username ="nikolajokic"
                }
            };
        }
    }
}
