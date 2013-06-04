﻿using LINQBridge.DynamicCore;
using Microsoft.VisualStudio.DebuggerVisualizers;
using System.IO;

namespace LINQBridge.DynamicVisualizer.V11
{
    public static class Settings
    {
        public static string AssemblyName = typeof(Settings).Assembly.ManifestModule.Name;

        public static string AssemblyLocation = typeof(Settings).Assembly.Location;
    }

    public class DynamicDebuggerVisualizerObjectSourceV11 : VisualizerObjectSource
    {
        public override void GetData(object target, Stream outgoingData)
        {
            DynamicObjectSource.BroadCastData(target, outgoingData);
        }
    }
}