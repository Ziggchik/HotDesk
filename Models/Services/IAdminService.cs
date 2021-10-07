using System;
using System.Collections.Generic;
using System.Linq;

namespace HotDesk.Models.Services
{
    public interface IAdminService
    {
        T Get<T>(Func<T, bool> predicate) where T : class;
        IQueryable <T> GetAll<T>() where T : class;
        void Add<T>(T item) where T : class;
        void Remove<T>(T item) where T : class;
        IEnumerable <Device> UpdateDevices(int[] deviceIds);
    }
}
