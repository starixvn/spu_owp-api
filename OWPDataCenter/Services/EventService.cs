namespace OWPDataCenter.Services.Implement
{
    using Fanex.Data.Repository;
    using Interfaces;
    using Models;
    using System.Collections.Generic;

    public class EventService : BaseService, IEventServices
    {
        public EventService()
            : base()
        {
        }

        public IEnumerable<EventInfo> GetSelectedEvents(ICriteria criteria)
        {
            return _repository.Fetch<EventInfo>(criteria);
        }
    }
}