using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Windows.Networking.Connectivity;

namespace BusinessLayer.Connection {
    class Network {
        public static bool IsInternetConnected() {
            var isInternetConnected = false;
            var connectionProfile = NetworkInformation.GetInternetConnectionProfile();

            if (connectionProfile != null) {
                var connectivityLevel = connectionProfile.GetNetworkConnectivityLevel();
                isInternetConnected = connectivityLevel == NetworkConnectivityLevel.InternetAccess;
            }

            return isInternetConnected;
        }
    }
}
