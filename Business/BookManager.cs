using System;
using System.Collections.Generic;
using DataAccess;
using Entities;

namespace Business
{
    public class BookManager
    {
        // 1. Değişken tanımlamasından sonra noktalı virgül ekledim
        BookDal _bookDal = new BookDal();

        // 2. GET ALL: Tüm kitapları listeler
        public List<Book> GetAll()
        {
            return _bookDal.GetAll();
        }

        // 3. ADD: Kitap ekleme kuralları
        public void Add(Book book)
        {
            if (string.IsNullOrEmpty(book.BookName))
            {
                throw new Exception("Kitap ismi boş olamaz!");
            }
            _bookDal.Add(book);
        }

        // 4. DELETE: Silme kuralı (İki taneydi, teke düşürdüm ve kontrol ekledim)
        public void Delete(int id)
        {
            if (id <= 0)
            {
                throw new Exception("Geçersiz kitap seçimi!");
            }
            _bookDal.Delete(id);
        }

        // 5. SEARCH: Arama kuralı (Teke düşürüp mantıklı hale getirdim)
        public List<Book> GetBySearch(string key)
        {
            // Eğer arama kutusu boşsa tüm listeyi, değilse filtrelenmiş listeyi döner
            return string.IsNullOrEmpty(key) ? _bookDal.GetAll() : _bookDal.GetBySearch(key);
        }
    }
}