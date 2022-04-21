using System;
using System.Linq;

namespace SpencersQualityQuotes.Models
{
	public interface IQuoteRepository
	{
        public IQueryable<Quotation> Quotes { get; }

        void AddQuote(Quotation quote);
        void UpdateQuote(Quotation quote);
        void DeleteQuote(Quotation quote);
    }
}

