﻿using System.Threading.Tasks;

namespace Thinktecture.IdentityServer.Core.Connect.Services
{
    public interface ITransientDataRepository<T>
    {
        Task StoreAsync(string key, T value);
        Task<T> GetAsync(string key);
        Task RemoveAsync(string key);
    }
}
