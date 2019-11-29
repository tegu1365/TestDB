using System;
using System.Collections.Generic;
using System.Text;
using TestDatabase.Models;
using System.Linq;

namespace TestDatabase.Services
{
    class FileService
    {
        TestContext _context;

        public FileService(TestContext context)
        {
            _context = context;
        }

        public void AddFile(string p)
        {
            File file = new File();
            file.Path = p;
            _context.Files.Add(file);
            _context.SaveChanges();
        }

        public File GetFile(string p)
        {
            return _context.Files.First(x => x.Path == p);
        }

        public void DeleteFile(string p)
        {
            _context.Files.Remove(GetFile(p));
            _context.SaveChanges();
        }

        public void ChangePath(string oldP, string newP)
        {
            File file = GetFile(oldP);
            file.Path = newP;
            _context.SaveChanges();

        }
    }
}
