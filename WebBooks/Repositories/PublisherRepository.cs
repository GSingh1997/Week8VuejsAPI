using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBooks.Entities;
using WebBooks.Models;
using WebBooks.ViewModels;

namespace WebBooks.Repositories
{
    public class PublisherRepository
    {
        private BooksVMContext db;
        public PublisherRepository(BooksVMContext booksVMContext)
        {
            db = booksVMContext;
        }
        public List<PublisherBasic> List()
        {
            return db.Publishers.Select(
                p => new PublisherBasic
                {
                    Id = p.Id,
                    Name = p.Name
                }).OrderBy(p => p.Name).ToList();
        }

        public Publisher SelectId(int id)
        {
            return db.Publishers.FirstOrDefault(p => p.Id == id);
        }
       
    }
}
