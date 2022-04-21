using System;
using System.Linq;
using System.Threading.Tasks;

namespace SpencersQualityQuotes.Models
{
	public class EFQuoteRepository : IQuoteRepository
	{
        private QuoteContext _ctx;

		public EFQuoteRepository(QuoteContext context)
		{
            _ctx = context;
		}

        public IQueryable<Quotation> Quotes
        {
            get
            {
                return _ctx.Quotes;
            }
        }

        public void TrySaveContext()
        {
            try
            {
                _ctx.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void AddQuote(Quotation quote)
        {
            _ctx.Quotes.Add(quote);
            TrySaveContext();
        }

        public void DeleteQuote(Quotation quote)
        {
            _ctx.Quotes.Remove(quote);
            TrySaveContext();
        }

        public void UpdateQuote(Quotation quote)
        {
            _ctx.Quotes.Update(quote);
            TrySaveContext();
        }
    }
}

