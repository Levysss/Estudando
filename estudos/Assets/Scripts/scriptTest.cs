using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MeuJogo.Bus.Maneger;

public class scriptTest : MonoBehaviour
{
    public bool checkStatus= false;

    [Range(-5,5)]
    public int value01;
    public int value02;

    private void Update()
    {
        if(value01<0)
        {
            Debug.Log("Menor que 0");
        }
        else if(value01 >0)
        {
            Debug.Log("Maior que 0");
        }
        else
        {
            Debug.Log("Igual a 0");
        }
    }
}
