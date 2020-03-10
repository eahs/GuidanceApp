using System;
namespace GuidanceApp
{
    public class GlobalConstants
    {
        // REST configuration
        public static readonly string EndPointURL = "http://eahsguidance.me";
        public static readonly int RequestTimeout = 10 * 1000; // In milliseconds, time to return request

        public static readonly string JobsEndPointRequestURL = "/api/Jobs";
    }
}