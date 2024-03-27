using System;
using System.Timers;

class Clock
{
    DateTime alarmTime = DateTime.Now;
    public delegate void AlarmHandler(object sender, DateTime args);
    public delegate void TickHanlder(object sender, DateTime args);

    public event AlarmHandler OnAlarm;
    public event TickHanlder OnTick;

    public Clock()
    {
        OnAlarm += Alarm;
        OnTick += Tick;
    }

    public void Alarm(object sender, DateTime time)
    {
        Console.WriteLine("命定之刻" + time + "已至！");
    }

    public void Tick(object sender, DateTime time)
    {
        Console.WriteLine("现在时间是" + time);
    }

    public void Start()   //启动
    {
        while (true)
        {
            DateTime now = DateTime.Now;
            OnTick(this, now);
            if (now.ToString() == alarmTime.ToString())
            {
                OnAlarm(this, alarmTime);
            }
            System.Threading.Thread.Sleep(1000);
        }
    }

    public void SetAlarmTime(DateTime atime)    //闹钟时间
    {
        Console.WriteLine(atime);
        alarmTime = atime;
    }
}

class Program
{
    static void Main()
    {
        Clock clock = new Clock();
        DateTime datetime = new DateTime();
        datetime = DateTime.Now.AddSeconds(10);   //xx后响起
        clock.SetAlarmTime(datetime);
        clock.Start();
    }
}