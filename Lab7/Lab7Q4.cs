// Create a class AlarmClock with an event Alarm using the built-in EventHandler delegate
// Create a method Trigger Alarm in the Alarm Clock class that raises the Alarm event.
// Create a subscriber class AlarmSubscriber that listens to the Alarm even and handles it.

namespace Lab7
{
    public class AlarmClock
    {
        public event EventHandler Alarm;

        public void TriggerAlarm()
        {
            Console.WriteLine("Alarm is about to go off...");
            Alarm?.Invoke(this, EventArgs.Empty);
        }
    }

    public class AlarmSubscriber
    {
        public void OnAlarmTriggered(object sender, EventArgs e)
        {
            Console.WriteLine("Alarm has been triggered! Time to wake up!");
        }
    }

    public class Q4
    {
        public static void run(string[] args)
        {
            AlarmClock alarmClock = new AlarmClock();
            AlarmSubscriber alarmSubscriber = new AlarmSubscriber();

            alarmClock.Alarm += alarmSubscriber.OnAlarmTriggered;

            alarmClock.TriggerAlarm();
        }
    }
}