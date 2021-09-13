using System.Collections.Generic;

namespace SignalRConsoleEntities
{
    public class SensorData
    {
        public string Timestamp { get; set; }
        public string Type { get; set; }
        public string Id { get; set; }
        public Dictionary<string, string> Data { get; set; }
    }
}
