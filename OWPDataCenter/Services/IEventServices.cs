namespace OWPDataCenter.Services.Interfaces
{
    using Fanex.Data.Repository;
    using Models;
    using System.Collections.Generic;

    public interface IEventServices
    {
        IEnumerable<EventInfo> GetSelectedEvents(ICriteria criteria);
    }
}