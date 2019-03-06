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
using SignUpTest.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(Message_Droid))]

namespace SignUpTest.Droid
{
    public class Message_Droid : IMessage
    {
        /// <summary>
        /// 긴 Toast메시지
        /// </summary>
        /// <param message="보여질 메세지"></param>
        public void Longtime(string message)
        {
            Toast.MakeText(Android.App.Application.Context, message, ToastLength.Long).Show();
        }
        /// <summary>
        /// 짧은 Toast메시지
        /// </summary>
        /// <param message="보여질 메세지"></param>
        public void Shorttime(string message)
        {
            Toast.MakeText(Android.App.Application.Context, message, ToastLength.Short).Show();
        }
    }
}