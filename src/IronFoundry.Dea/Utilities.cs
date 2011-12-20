﻿namespace IronFoundry.Dea
{
    using System;
    using System.IO;
    using System.Net;
    using System.Net.Sockets;
    using Microsoft.VisualBasic.Devices;

    public static class Utility
    {
        public static int GetEpochTimestamp()
        {
            return (int)((DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds);
        }

        public static void CopyDirectory(DirectoryInfo source, DirectoryInfo target)
        {
            var c = new Computer();
            c.FileSystem.CopyDirectory(source.FullName, target.FullName, true);
        }

        // NB: this allows "break on all exceptions" to be enabled in VS without having the SocketException break
        [System.Diagnostics.DebuggerStepThrough]
        public static ushort FindNextAvailablePortAfter(ushort argStartingPort)
        {
            for (ushort port = argStartingPort; port < 65535; port++)
            {
                try
                {
                    var ep = new IPEndPoint(IPAddress.Any, port);
                    var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    socket.Bind(ep);
                    socket.Close();
                    // Port available
                    return port;
                }
                catch (SocketException) { }
            }

            return ushort.MinValue;
        }
    }
}