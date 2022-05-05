using System;
using System.Collections.Generic;
using System.Text;

namespace TBR.Core.Interfaes
{
    public interface IBookRepo
    {
        /// <summary>
        /// returning how many rows were changed in the data base.
        /// </summary>
        /// <param name="bookToInsert"></param>
        /// <returns></returns>
        public int InsertBook(Book bookToInsert);

        public Book GetByISBN(int isbn);

    }
}
