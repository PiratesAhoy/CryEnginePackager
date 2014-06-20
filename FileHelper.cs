using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hearts_of_Oak_Packager
{
    class FileHelper
    {
        public static string[] IncludeFolders =
        {
            "Bin32",
            "Bin32_Dedicated",
            "Bin64",
            "Bin64_Dedicated",
            "Engine",
            "Localization"
        };

        public static string[] IgnoreExtensions = 
		{
			".bak",
			".bak2",
			".cry",
			".max",
			".psd",
			".log",
			".lib",
			".pdb",
			".exp",
            ".zip",
            ".ilk"
		};

        public static string[] IgnoreFolders =
		{
			"tools",
			"editor",
			"code",
			"logBackups",
			"statoscope",
			"bintemp",
			"user",
			"rc",
            "flashassets"
		};

        public static string[] IgnoreFiles =
		{
			"Editor.exe",
			"error.bmp",
			"error.dmp",
			"luac.out",
			"tags.txt",
            "include.me"
		};

        public static string[] IgnoreCompress = 
        {
            "modes",
            "_FastLoad",
            "_LevelCache",
            "Levels"
        };
    }
}
