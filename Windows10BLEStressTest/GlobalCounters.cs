﻿using System;
using System.Threading;

namespace Windows10BLEStressTesst
{
    public static class GlobalCounters
    {
        public static int WatchersCreated;
        public static int WatchersStopped;
        public static int AdvertisementsSeen;

        public static int DevicesCreated;
        public static int DevicesConnected;
        public static int DevicesClosed;

        public static void DisplayCounters()
        {
            Console.Write(
                $"\rWatchers (Crt: {WatchersCreated}, Stp: {WatchersStopped}, Adv: {AdvertisementsSeen}), Devices (Crt: {DevicesCreated}, Cnct: {DevicesConnected}, Cls: {DevicesClosed} )");
        }

        public static void IncrementWatchersCreated()
        {
            Interlocked.Increment(ref WatchersCreated);
            DisplayCounters();
        }

        public static void IncrementWatchersClosed()
        {
            Interlocked.Increment(ref WatchersStopped);
            DisplayCounters();
        }

        public static void IncrementAdvertisementsSeen()
        {
            Interlocked.Increment(ref AdvertisementsSeen);
            DisplayCounters();
        }

        public static void IncrementDevicesCreated()
        {
            Interlocked.Increment(ref DevicesCreated);
            DisplayCounters();
        }

        public static void IncrementDevicesConnected()
        {
            Interlocked.Increment(ref DevicesConnected);
            DisplayCounters();
        }

        public static void IncrementDevicesClosed()
        {
            Interlocked.Increment(ref DevicesClosed);
            DisplayCounters();
        }
    }
}