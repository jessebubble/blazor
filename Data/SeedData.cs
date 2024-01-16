namespace Blazor.Data;

public static class SeedData
{
    public static void Initialize(PizzaStoreContext db)
    {
        var specials = new PizzaSpecial[]
        {
            new() 
                {
                    Name = "Pizza Margherita",
                    Description = "The original Pizza from Napoli",
                    BasePrice = 9.99M,
                    ImageUrl = "images/pizza/cat.png"
                },
            new() 
                {
                    Id = 2,
                    Name = "Pizza Napoletana",
                    Description = "The original Pizza from Napoli",
                    BasePrice = 10.99M,
                    ImageUrl = "images/pizza/bunny.png"
                },
            new() 
                {
                    Id = 3,
                    Name = "Pizza Bianca",
                    Description = "The original Pizza from Napoli",
                    BasePrice = 11.99M,
                    ImageUrl = "images/pizza/sponsor.png"
                },
            new()
                {
                    Id = 4,
                    Name = "Pizza Funghi",
                    Description = "The original Pizza from Napoli",
                    BasePrice = 12.99M,
                    ImageUrl = "images/pizza/hello.png"
                },
            new()
                {
                    Id = 5,
                    Name = "Pizza Capricciosa",
                    Description = "The original Pizza from Napoli",
                    BasePrice = 13.99M,
                    ImageUrl = "images/pizza/glitch.png"
                }
        };
        db.Specials.AddRange(specials);
        db.SaveChanges();
    }
}