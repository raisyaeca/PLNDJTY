using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Newtonsoft.Json.Linq;
using PushNotification.Plugin;
using PushNotification.Plugin.Abstractions;

namespace LoginNavigation.Droid
{
    public class CrossPushNotificationListener : IPushNotificationListener
    {
        public void OnError(string message, DeviceType deviceType)
        {
            //throw new NotImplementedException();
        }

        public void OnMessage(JObject values, DeviceType deviceType)
        {
            //throw new NotImplementedException();
        }

        public void OnRegistered(string token, DeviceType deviceType)
        {
            App.Mostrartoken(token);
            //throw new NotImplementedException();
        }

        public void OnUnregistered(DeviceType deviceType)
        {
            //throw new NotImplementedException();
        }

        public bool ShouldShowNotification()
        {
            return true;
            //throw new NotImplementedException();
        }
    }
}