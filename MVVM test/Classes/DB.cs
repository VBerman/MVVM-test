using MVVM_test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_test.Classes
{
    class DB
    {
        private static Session2Context _instance;

        public DB()
        {

        }
        public static Session2Context Instance
        {
            get
            {
                _instance = _instance ?? new Session2Context();
                return _instance;
            }
        }
    }
}
