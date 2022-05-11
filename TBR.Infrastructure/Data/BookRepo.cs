using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TBR.Core.Entities;
using TBR.Core.Interfaes;

namespace TBR.Infrastructure.Data
{
    public class BookRepo : IBookRepo
    {
        private readonly TBRDbContext _context;
        public BookRepo(TBRDbContext dbContext)
        {
            _context = dbContext;
        }
        public Task<Book> GetByISBN(string ISBN)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Book>> GetByTitle(string title)
        {
            return await _context.Books.Where(b => b.Title == title).ToListAsync();
        }


        public async Task<IEnumerable<Book>> GetByAuthor(string author)
        {
            return await _context.Books.Where(b => b.Authors.Contains(author)).ToListAsync();
        }

        public async Task InsertBook(Book bookToInsert)
        {
            _context.Books.Add(bookToInsert);

            await _context.SaveChangesAsync();
        }
    }
}
