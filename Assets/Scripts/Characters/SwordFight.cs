using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordFight : MonoBehaviour
{
    private Animator anim;
    public float cooldownTime = 2f;
    private float nextFireTime = 0f;
    public static int noOfClick = 0;
    float lastClickedTime = 0f;
    float maxComboDelay = 1;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnClick() 
    { 
        lastClickedTime = Time.time;
        noOfClick++;
        if(noOfClick == 1)
        {

        }


    }

}
