using System;
using Microsoft.EntityFrameworkCore;

namespace SpencersQualityQuotes.Models
{
    public class QuoteContext : DbContext
    {
        public QuoteContext(DbContextOptions<QuoteContext> options) : base(options)
        {
        }

        public DbSet<Quotation> Quotes { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Quotation>().HasData(
                new Quotation
                {
                    Id = 1,
                    Quote = "You can make more friends in two months by becoming interested in other people than you can in two years by trying to get other people interested in you.",
                    Author = "Dale Carnegie",
                    Citation = "How to Win Friends and Influence People"
                },
                new Quotation
                {
                    Id = 2,
                    Quote = "A study at the University of Utah found that if you ask someone why he is friendly with someone else, he’ll say it is because he and his friend share similar attitudes. But if you actually quiz the two of them on their attitudes, you’ll find out that what they actually share is similar activities. We’re friends with the people we do things with, as much as we are with the people we resemble. We don’t seek out friends, in other words. We associate with the people who occupy the same small, physical spaces that we do.",
                    Author = "Malcolm Gladwell",
                    Citation = "The Tipping Point: How Little Things Can Make a Big Difference"
                },
                new Quotation
                {
                    Id = 3,
                    Quote = "Winning at money is 80 percent behavior and 20 percent head knowledge. What to do isn’t the problem; doing it is. Most of us know what to do, but we just don’t do it. If I can control the guy in the mirror, I can be skinny and rich.",
                    Author = "Dave Ramsey",
                    Citation = "The Total Money Makeover: A Proven Plan for Financial Fitness"
                }
            ) ;
        }
    }
}

