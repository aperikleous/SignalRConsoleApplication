using Microsoft.AspNetCore.SignalR.Client;
using Newtonsoft.Json;
using SignalRConsoleDatabase;
using SignalRConsoleEntities;
using System;

namespace SignalRConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbConnection = new DBConnection();
            var connection = new HubConnectionBuilder()
                    .WithUrl("http://localhost:5000/messagehub")
                    .Build();
            connection.On("ReceiveMessage", (string sensorData) =>
            {
                var sensor = JsonConvert.DeserializeObject<SensorData>(sensorData);
                if (sensor.Type.Equals("SensorData")) 
                    dbConnection.StoreSensorData(sensor);
            });

            connection.On("Stop", () =>
            {
                Console.WriteLine("Ending connection...");
                connection.StopAsync().Wait();
            });

            connection.StartAsync().Wait();
            connection.InvokeAsync("SendData");
            connection.InvokeAsync("EndConnection");
            
            Console.ReadKey();
        }
    }
}
