using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LifeManager : MonoBehaviour
{
    public float life;

    public void UpdateLife(float point)
    {
        Debug.Log("vidaupdate");

        if (life + point <= 0)
        {
            SceneManager.LoadScene("SampleScene");
        }
        else
        {
            life += point;
        }

    }

}
