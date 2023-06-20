using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public class WorldSaveGameManager : MonoBehaviour
{
    public static WorldSaveGameManager instance;

    [SerializeField] 
    int worldSceneIndex = 1;

    private void Awake()
    {
        // bu scriptin sadece bir instance ý olabilir eðer varsa yok etmek gerekir(singleton)
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
    public IEnumerator LoadNewGame()
    {
        AsyncOperation loadOparation = SceneManager.LoadSceneAsync(worldSceneIndex);
        yield return null;
    }
}
