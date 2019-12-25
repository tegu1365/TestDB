using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestDatabase.Models;

namespace TestDatabase
{
    public class ContentService
    {
        TestContext _context;

        public ContentService(TestContext context)
        {
            _context = context;
        }

        public void AddContent(string title, string author, Category category, File file, Profile uploader)
        {
            Content c = new Content();

            c.Title = title;

            c.Author = author;

            c.Category = category;

            c.File = file;

            c.Uploader = uploader;  
            
            _context.Contents.Add(c);

            _context.SaveChanges();
        }

        public Content GetContent(string title, string author)
        {
           return  _context.Contents.First(c => c.Author == author && c.Title == title );
        }

        public void DeleteContent(string title, string author)
        {
            Content c = GetContent(title, author);

            _context.Contents.Remove(c);

            _context.SaveChanges();
        }

        public void UpdateTitle(string title, string author, string newTitle)
        {
          Content c = GetContent(title, author);
            c.Title = newTitle;
            _context.SaveChanges();
        }

        public void UpdateAuthor(string title, string author, string newAuthor)
        {
            Content c = GetContent(title, author);
            c.Author = newAuthor;
            _context.SaveChanges();
        }

        public void UpdateCategory(string title, string author, Category category)
        {
            Content c = GetContent(title, author);
            c.Category = category;
            _context.SaveChanges();
        }

        public void UpdateFile(string title, string author, File file)
        {
            Content c = GetContent(title, author);
            c.File = file;
            _context.SaveChanges();
        }
    }
}