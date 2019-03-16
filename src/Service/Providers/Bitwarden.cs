using System.Collections.Generic;
using System.Threading.Tasks;
using CliWrap.Models;
using PasswordManager.Model;
using PasswordManager.Service.Contract;

namespace Service.Providers
{
    public class Bitwarden : IPasswordAdapter
    {
        public Task<bool> Login(string user, string pathToAskPassFile = null)
        {
            throw new System.NotImplementedException();
        }

        public Task<(bool status, string account)> GetStatus()
        {
            throw new System.NotImplementedException();
        }

        public Task<IList<Record>> GetRecords()
        {
            // bw get item <id>
            // or bw list items --search (term)
            throw new System.NotImplementedException();
            // TODO bw has special direct search - implement one just for it
        }

        public Task<IDictionary<string, Record>> GetRecordsMap()
        {
            throw new System.NotImplementedException();
        }

        public void GetFieldById(string id, string fieldName, bool copyToClipboard = false)
        {
            throw new System.NotImplementedException();
        }
    }
}