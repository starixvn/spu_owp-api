namespace OWPDataCenter.Controllers
{
    using Criteria;
    using OWPDataCenter.Models;
    using Services.Implement;
    using System;
    using System.Collections.Generic;
    using System.Web.Http;

    public class EventsController : ApiController
    {
        private EventService _eventService;

        public EventsController()
        {
            _eventService = new EventService();
        }

        public IEnumerable<EventInfo> GetSelectedEvents()
        {
            try
            {
                var events = _eventService.GetSelectedEvents(new GetSelectedEventsCriteria());
                return events;
            }
            catch (Exception exception)
            {
                return new List<EventInfo>();
            }

        }
    }
}
