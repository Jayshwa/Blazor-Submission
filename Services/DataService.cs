using System;
using System.Collections.Generic;

namespace AdvancedBlazorComponents
{
    public class DataService
    {
        public List<Event> GetEvents()
        {
            var events = new List<Event>();
            for (int i = 1; i <= 100; i++)
            {
                events.Add(new Event
                {
                    Name = $"Event {i}",
                    Date = DateTime.Now.AddDays(i),
                    Location = $"Location {i}"
                });
            }
            return events;
        }
    }

    public class Event
    {
        public string Name { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public string Location { get; set; } = string.Empty;
    }
}