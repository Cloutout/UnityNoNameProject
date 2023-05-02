using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// damage test etmek için oluþturuldu silinebilir.
public class DamageTest : MonoBehaviour
{
    public AttributesManager playerAtm;
    public AttributesManager enemyAtm;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F11))
        {
            playerAtm.DealDamage(enemyAtm.gameObject);
        }

        if (Input.GetKeyDown(KeyCode.F12))
        {
            enemyAtm.DealDamage(playerAtm.gameObject);
        }

    }
}
