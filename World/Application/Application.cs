/*
* I will add a license in shortly as I know this needs to be done.
* Please bare with me.
*/

using World.Simulation.Base;

namespace World
{
    /// <summary>
    ///     We need to start a class for the World Server
    /// </summary>
    public class Application
    {
        public static void Main(string[], args)
        {
            BaseApplication.BaseMain(args, "", new SimulationBase());
        }
    }
}