﻿
namespace SocketServer
{
    using System.Collections.Generic;

    using ServerLibrary;

    // singleton on actively connected clients
    public class ClientList : List<Client>
    {
        private ClientList()
        {
        }

        public static ClientList Instance { get; } = new ClientList();
    }
}