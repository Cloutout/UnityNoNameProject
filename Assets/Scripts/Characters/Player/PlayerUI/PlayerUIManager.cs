using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;
using UnityEditor;

public class PlayerUIManager : MonoBehaviour
{
    public static PlayerUIManager instance;

    [Header("NEWWORK JOIN")]

    [SerializeField]
    bool startGameAsClient;



    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
    private void Update()
    {
        if (startGameAsClient)
        {
            startGameAsClient = false;
            // ÖNCE KAPATMALIYIZ, ÇÜNKÜ BAÞLIK EKRANI SIRASINDA BIR ANA BILGISAYAR OLARAK BAÞLADIK
            NetworkManager.Singleton.Shutdown();
            //SONRA BIR CLIENT OLARAK YENIDEN BAÞLATIRIZ
            NetworkManager.Singleton.StartClient();
        }
    }
}
