using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class TittleScreenManager : MonoBehaviour
{
   public void StartNetworkAsHost()
    {
        NetworkManager.Singleton.StartHost();
    }
}
