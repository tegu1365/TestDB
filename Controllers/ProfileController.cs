using System;
using System.Collections.Generic;
using System.Text;
using TestDatabase.Models;
using TestDatabase.Services;

namespace TestDatabase.Controllers
{
   public class ProfileController
    {
        private ProfileService _service;

        public ProfileController(TestContext _context)
        {
            _service = new ProfileService(_context);
        }

        public void AddProfile(string[] args)
        {
            _service.AddProfile(args);
        }

        public void DeleteProfile(string[] args)
        {
            _service.DeleteProfile(args[0], args[1]);
        }

        public void RenameProfile(string[] args)
        {
            _service.RenameProfile(args[0], args[1], args[2]);
        }
        
        public void ChangeProfileType(string[] args)
        {
            if (args[2] == "Admin")
            {
                _service.ChangeProfileType(args[0], args[1], ProfileType.Admin);
            }
            else if (args[2] == "User")
            {
                _service.ChangeProfileType(args[0], args[1], ProfileType.User);
            }
        }
    }
}
