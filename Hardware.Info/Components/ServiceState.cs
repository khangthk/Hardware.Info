﻿namespace Hardware.Info
{
    public enum ServiceState
    {
        Unknown,
        Stopped,
        StartPending,
        StopPending,
        Running,
        ContinuePending,
        PausePending,
        Paused
    }
}