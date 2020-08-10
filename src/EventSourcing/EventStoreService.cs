using EventStore.ClientAPI;
using Microsoft.Extensions.Configuration;
using System;
using System.Data.Common;

namespace EventSourcing
{
    public class EventStoreService : IEventStoreService
    {
        private readonly IEventStoreConnection _connection;

        public EventStoreService(IConfiguration configuration)
        {
            //var connectionString = configuration.GetConnectionString("EventStoreConnection");
            //var connectionSettings = EventStore.ClientAPI.ConnectionString.GetConnectionSettings(connectionString);
            //var uri = GetUriFromConnectionString(connectionString);
            //_connection = EventStoreConnection.Create(connectionSettings, uri);

            _connection = EventStoreConnection.Create(configuration.GetConnectionString("EventStoreConnection"));
            _connection.ConnectAsync();
        }

        private static Uri GetUriFromConnectionString(string connectionString)
        {
            var builder = new DbConnectionStringBuilder { ConnectionString = connectionString };
            var connto = (string)builder["ConnectTo"];
            return connto == null ? null : new Uri(connto);
        }

        public IEventStoreConnection GetConnection() => _connection;
    }
}
