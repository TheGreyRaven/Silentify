using System.Collections.Generic;

namespace Silentify
{
    class Variables
    {
        public static bool SkipPreloading { get; set; }
        public static string Version { get; set; }
        public static readonly IList<string> loadingWords = new List<string>() {
            "Checking for update...",
            "All done!"
        };
    }
}
