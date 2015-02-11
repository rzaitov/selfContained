using System;

using WatchKit;
using Foundation;

namespace WatchKitExtension
{
    public class NotificationController : WKUserNotificationInterfaceController
    {
        public NotificationController(IntPtr handle)
            : base(handle)
        {
        }

        public override void Awake(NSObject context)
        {
            base.Awake(context);

            // Configure interface objects here.
            Console.WriteLine(string.Format("{0} awake with context", this));
        }

        public override void WillActivate()
        {
            // This method is called when the watch view controller is about to be visible to the user.
            Console.WriteLine(string.Format("{0} will activate", this));
        }

        public override void DidDeactivate()
        {
            // This method is called when the watch view controller is no longer visible to the user.
            Console.WriteLine(string.Format("{0} did deactivate", this));
        }
    }
}

