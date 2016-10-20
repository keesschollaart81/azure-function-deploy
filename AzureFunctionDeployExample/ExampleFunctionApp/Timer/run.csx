using System;

public static void Run(TimerInfo myTimer, TraceWriter log)
{
    log.Info($"Hello World at {myTimer.ScheduleStatus.Last:g}");
}