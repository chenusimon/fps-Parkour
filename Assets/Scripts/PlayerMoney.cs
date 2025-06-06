using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoney : MonoBehaviour
{
    public float availableMoney;

    public void UpdateMoney(float amount)
    {

        if(availableMoney + amount < 0)
        {
            //impedir compra
        }
        else
        {
            availableMoney += amount;

        }
    }

}
