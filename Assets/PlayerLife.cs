using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    public float userLife;

    public void UpdateLife(float damage)
    {

        if (userLife - damage < 0)
        {
            SceneManager.LoadScene("SampleScene");
        }
        else
        {
            userLife -= damage;

        }
    }
}
