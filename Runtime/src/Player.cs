using Packages.com.unity.mgobe.Runtime.src.Util;
using Lagame;

namespace Packages.com.unity.mgobe.Runtime.src
{
    public class Player
    {
        public static string Id => GamePlayerInfo.GetInfo().Id;

        public static string OpenId => GameInfo.OpenId;

        public static string Name => GamePlayerInfo.GetInfo().Name;

        public static string TeamId => GamePlayerInfo.GetInfo().TeamId;
        public ulong CustomPlayerStatus => GamePlayerInfo.GetInfo().CustomPlayerStatus;

        public static string CustomProfile => GamePlayerInfo.GetInfo().CustomProfile;

        public static NetworkState CommonNetworkState => GamePlayerInfo.GetInfo().CommonNetworkState;

        public static NetworkState RelayNetworkState => GamePlayerInfo.GetInfo().RelayNetworkState;
    }
}