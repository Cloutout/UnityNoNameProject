using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DamagePopUpGenerator : MonoBehaviour
{
    public static DamagePopUpGenerator current;
    public GameObject prefab;

    private void Awake()
    {
        current = this;
    }
    void Update()
    {
        //input geykeydown denemek i�in yaz�ld� oras� takedamagele ba�lanacak
        if (Input.GetKeyDown(KeyCode.F10)) 
        {
            CreatePopUp(Vector3.one,Random.Range(0,100).ToString(), Color.yellow);
        }
    }
    public void CreatePopUp(Vector3 position,string text, Color color)
    {
        var popup = Instantiate(prefab, position, Quaternion.identity);
        var temp = popup.transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        temp.text = text;
        temp.faceColor = color;

        Destroy(popup,1f);
    }
}