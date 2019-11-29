using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestDatabase.Models;

namespace TestDatabase.Services
{
    class ProfileService
    {
        private TestContext _context;

        public ProfileService (TestContext context)
        {
           _context = context;
        }

        public void AddProfile(string n, string e, string p, ProfileType pt)
        {
            Profile person = new Profile();

            person.Name = n;
            person.Email = e;
            person.Password = p;
            person.ProfileType = pt;

            _context.Profiles.Add(person);
            _context.SaveChanges();
        }

        public Profile GetProfile(string e, string p)
        {
            return _context.Profiles.First(x => x.Email == e && x.Password == p);
        }

        public void DeleteProfile(string e, string p)
        {
            _context.Profiles.Remove(GetProfile(e, p));
            _context.SaveChanges();
        }

        public void ReNameProfil(string e, string p, string newName)
        {
            Profile person = GetProfile(e, p);
            person.Name = newName;
            _context.SaveChanges();
        }

        public void ChangeProfileType(string e, string p, ProfileType newPT)
        {
            Profile person = GetProfile(e, p);
            person.ProfileType = newPT;
            _context.SaveChanges();
        }
    }
}
