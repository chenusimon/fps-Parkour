using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageScript : MonoBehaviour
{
    public float daño = -10f;
    public LifeManager lifeManager;



    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("dañado");
            lifeManager.UpdateLife(daño);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
