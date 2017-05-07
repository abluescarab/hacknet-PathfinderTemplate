using Pathfinder.Util;
using Pathfinder.Command;

namespace TemplateMod {
    public class TemplateMod : Pathfinder.IPathfinderMod {
        public const string Name = "";
        public const string Version = "1_0";
        public const string ID = Name + " v" + Version;
        public const string Homepage = "https://github.com/username/repository";
        public const string Author = "";
        public string Identifier => ID;

        public void Load() {
            Logger.Verbose("Loading " + ID + "...");
        }

        public void LoadContent() {
            Handler.AddCommand(Commands.MyCommand.Key, Commands.MyCommand.RunCommand, Commands.MyCommand.Description, true);
        }

        public void Unload() {
            Logger.Verbose("Unloading " + ID + "...");
        }
    }
}
