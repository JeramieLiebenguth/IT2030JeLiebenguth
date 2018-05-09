using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FinalProject.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<FinalProjectDB>
    {
        protected override void Seed(FinalProjectDB context)
        {
            var EventTypes = new List<EventType>
            {
                new EventType { EventTypeName = "Concert" },
                new EventType { EventTypeName = "Monument" },
                new EventType { EventTypeName = "Festival or Fair" },
                new EventType { EventTypeName = "Camp" },
                new EventType { EventTypeName = "Class or Workshop" },
                new EventType { EventTypeName = "Convention" },
                new EventType { EventTypeName = "Tour" },
                new EventType { EventTypeName = "Dinner" },
                new EventType { EventTypeName = "Game" },
                new EventType { EventTypeName = "Party or Social Gathering" }
            };

            var Event = new List<Event>
            {
                new Event { Title = "Metallica Live",  },
                new Event { Title = "Trans Siberian Orchestra" },
                new Event { Title = "Judas Priest" },
                new Event { Title = "Camp" },
                new Event { Title = "Class or Workshop" },
                new Event { Title = "Convention" },
                new Event { Title = "Tour" },
                new Event { Title = "Dinner" },
                new Event { Title = "Game" },
                new Event { Title = "Party or Social Gathering" },
                new Event { Title = "Metallica Live" },
                new Event { Title = "Monument" },
                new Event { Title = "Festival or Fair" },
                new Event { Title = "Camp" },
                new Event { Title = "Class or Workshop" },
                new Event { Title = "Convention" },
                new Event { Title = "Tour" },
                new Event { Title = "Dinner" },
                new Event { Title = "Game" },
                new Event { Title = "Party or Social Gathering" },
                new Event { Title = "Metallica Live" },
                new Event { Title = "Monument" },
                new Event { Title = "Festival or Fair" },
                new Event { Title = "Camp" },
                new Event { Title = "Class or Workshop" },
                new Event { Title = "Convention" },
                new Event { Title = "Tour" },
                new Event { Title = "Dinner" },
                new Event { Title = "Game" },
                new Event { Title = "Party or Social Gathering" },
            };
        }
    }
}