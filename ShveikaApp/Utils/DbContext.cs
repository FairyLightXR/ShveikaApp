using ShveikaApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShveikaApp.Utils
{
    internal class DbContext
    {
        private static ShveModel _context { get; set; }
        public static ShveModel Context
        {
            get => _context ?? (_context = new ShveModel());  
        }
    }
}
