using System;
using System.Collections.Generic;
using System.IO;
using Json;
using Newtonsoft.Json;

namespace Json
{
    public class Book
    {
        public int PublishingHouseId { get; set; }
        public string Title { get; set; }
        public PublishingHouse PublishingHouse { get; set; }
    }
}
