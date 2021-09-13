using Microsoft.AspNetCore.SignalR;
using SignalRConsoleEntities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SignalRConsoleApp
{
    public class MessageHub : Hub
    {
        public async Task SendData()
        {
            SensorData sensorData = new SensorData()
            {
                Timestamp = "1545581650234",
                Type = "SensorData",
                Id = Guid.NewGuid().ToString(),
                Data = new Dictionary<string, string>
                {
                    {"Sensor1", "12.3"},
                    {"Sensor2", "10.0"},
                    {"Sensor3", "12.3"},
                    {"Sensor4", "open"}
                }
            };
            var serialized = Newtonsoft.Json.JsonConvert.SerializeObject(sensorData);
            await Clients.All.SendAsync("ReceiveMessage", serialized);
        }

        public async Task EndConnection()
        {
            await Clients.All.SendAsync("Stop");
        }
    }
}
