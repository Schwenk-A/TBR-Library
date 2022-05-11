using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TBR.Core.Entities;

namespace TBR.Core.Interfaes
{
    public interface IBookRepo
    {
        /// <summary>
        /// returning how many rows were changed in the data base.
        /// </summary>
        /// <param name="bookToInsert"></param>
        /// <returns></returns>
        public Task InsertBook(Book bookToInsert);


        public Task<Book> GetByISBN (string isbn);
        public Task <IEnumerable<Book>> GetByTitle (string title);

    }
}
