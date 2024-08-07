using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayerIOClient;

namespace Project.Networking
{
    public class NetworkClient : MonoBehaviour
    {
        public static NetworkClient mInstance;

        public static string gameId = "poker-ju7fxknktumjiu4unpes4g";

        public static NetworkClient getInstance
        {
            get
            {
                if (mInstance == null)
                {
                    mInstance = new NetworkClient();
                }

                return mInstance;
            }
        }

        public void RegisterUser (string username, string password)
        {
            PlayerIO.Authenticate(gameId, "public", new Dictionary<string, string>
            {
                {"register", "true"},
                {"username", username},
                {"password", password}
            }, null, delegate (Client client)
            {
                Debug.Log("Registration successfull");
            }, delegate (PlayerIOError error)
            {
                Debug.Log("Registration falied : " + error.Message);
            });
        }
    }

}

