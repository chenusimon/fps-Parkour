using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MercanciaScript : MonoBehaviour
{
    public float precio;
    public PlayerMoney dineroManager;

    void Start()
    {
        dineroManager = FindObjectOfType<PlayerMoney>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")) 
        {
            dineroManager.UpdateMoney(precio);
            Destroy(gameObject);
        }

    }
}
