﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SpencersQualityQuotes.Models;

namespace SpencersQualityQuotes.Migrations
{
    [DbContext(typeof(QuoteContext))]
    [Migration("20220421044441_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.24");

            modelBuilder.Entity("SpencersQualityQuotes.Models.Quotation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Citation")
                        .HasColumnType("TEXT");

                    b.Property<string>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Quote")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Subject")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Quotes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Dale Carnegie",
                            Citation = "How to Win Friends and Influence People",
                            Quote = "You can make more friends in two months by becoming interested in other people than you can in two years by trying to get other people interested in you."
                        },
                        new
                        {
                            Id = 2,
                            Author = "Malcolm Gladwell",
                            Citation = "The Tipping Point: How Little Things Can Make a Big Difference",
                            Quote = "A study at the University of Utah found that if you ask someone why he is friendly with someone else, he’ll say it is because he and his friend share similar attitudes. But if you actually quiz the two of them on their attitudes, you’ll find out that what they actually share is similar activities. We’re friends with the people we do things with, as much as we are with the people we resemble. We don’t seek out friends, in other words. We associate with the people who occupy the same small, physical spaces that we do."
                        },
                        new
                        {
                            Id = 3,
                            Author = "Dave Ramsey",
                            Citation = "The Total Money Makeover: A Proven Plan for Financial Fitness",
                            Quote = "Winning at money is 80 percent behavior and 20 percent head knowledge. What to do isn’t the problem; doing it is. Most of us know what to do, but we just don’t do it. If I can control the guy in the mirror, I can be skinny and rich."
                        },
                        new
                        {
                            Id = 4,
                            Author = "Shad Baird",
                            Quote = "This is a test quote to delete"
                        },
                        new
                        {
                            Id = 5,
                            Author = "Shad Baird",
                            Quote = "This is a test quote to delete 2"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
