﻿using System;

namespace Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            client.Connect();
            Chat chat = new Chat(client.SignIn());
            client.Start();
            chat.Start();
        }
    }
}
