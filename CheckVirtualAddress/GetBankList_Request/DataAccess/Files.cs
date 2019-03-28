using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GetBankList.Models;
using System.Net;

namespace GetBankList.DataAccess
{
    public class Files
    {
        public Bank[] GetBanks()
        {
            return new ReadFile<Bank>().Get(@"\banks.json");
        }

       
    }

    
}