using Google.Apis.Books.v1.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TBR.Infrastructure.GoogleBookAPI
{
    public interface IGoogleBookAPI
    {
        public Task<IEnumerable<Volume>> GetByTitleAsync(string title);
        public Task<IEnumerable<Volume>> GetByAuthorAsync(string author);
        public Task<Volume> GetByISBNAsync(string isbn);
     
    }
}
