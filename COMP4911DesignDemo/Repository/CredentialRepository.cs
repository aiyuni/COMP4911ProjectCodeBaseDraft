using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COMP4911DesignDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace COMP4911DesignDemo.Repository
{
    public class CredentialRepository : IDataRepository<Credential>
    {
        private readonly ApplicationDbContext _credentialContext;

        public CredentialRepository(ApplicationDbContext context)
        {
            this._credentialContext = context;
        }

        void IDataRepository<Credential>.Add(Credential entity)
        {
            if (_credentialContext.Credentials.Any(p => p.CredentialId == entity.CredentialId) == false)
            {
                System.Diagnostics.Debug.WriteLine("record doesnt exist, adding credential...");
                _credentialContext.Credentials.Add(entity);
            }
            else
            {
                System.Diagnostics.Debug.Write("record already exists, updating credential...");
                Credential existingCredential = _credentialContext.Credentials.FirstOrDefault(p => p.CredentialId == entity.CredentialId);
                this.Update(existingCredential, entity);
            }

            _credentialContext.SaveChanges();
            _credentialContext.Entry(entity).State = EntityState.Detached;
        }

        void IDataRepository<Credential>.Delete(Credential entity)
        {
            throw new NotImplementedException();
        }

        Credential IDataRepository<Credential>.Get(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Credential> IDataRepository<Credential>.GetAll()
        {
            return _credentialContext.Credentials.ToList();
        }

        public void Update(Credential dbEntity, Credential entity)
        {
            _credentialContext.Entry(dbEntity).CurrentValues.SetValues(entity);
            System.Diagnostics.Debug.Write("Updated credentials...");
        }
    }
}
