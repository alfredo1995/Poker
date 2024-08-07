using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Project.Networking
{
    public class NetworkClient : MonoBehaviour
    {
        public static NetworkClient mInstance;

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
    }
}

