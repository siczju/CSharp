
using Exercicio2.Entities;

namespace Exercicio2;

internal class Program
{
    static void Main(string[] args)
    {

        Post post1 = new Post(
            DateTime.Parse("21/06/2018 13:05:44"),
            "Traveling to New Zealand",
            "I'm going to visit this wonderful country!",
            12);

        post1.AddComment(new Comment("Have a nice trip"));
        post1.AddComment(new Comment("Wow that's awesome!"));
        
        Post post2 = new Post(
            DateTime.Parse("28/07/2018 23:14:19"),
            "Good night guys",
            "See you tomorrow",
            5);

        post2.AddComment(new Comment("Good night"));
        post2.AddComment(new Comment("May the force be with you"));

        Console.Write(post1);
        Console.Write(post2);
        
        
    }
}
