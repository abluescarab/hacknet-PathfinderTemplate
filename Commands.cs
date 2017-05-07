using System;
using System.Collections.Generic;
using Hacknet;

namespace TemplateMod {
    static class Commands {
        public static class MyCommand {
            public const string Key = "mycommand";
            public const string Description = "This command does something";
            public const string Usage = "Usage: " + Key;

            public static bool RunCommand(OS os, List<string> args) {
                return false;
            }

            public static bool LoadSettings(OS os, KeyValueFile file) {
                return false;
            }

            public static bool SaveSettings(OS os, KeyValueFile file) {
                return false;
            }
        }
    }
}
