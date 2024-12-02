using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace Monsalma_Maui_v010006
{
    internal class Program : MauiApplication
    {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

        static void Main(string[] args)
        {
            var app = new Program();
            app.Run(args);
        }
    }
}
