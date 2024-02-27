using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MeuJogo.Bus.Maneger;

public enum Animals
{
    Dog,
    Cat,
    Fish
}
public class scriptTest : MonoBehaviour
{
    public string minhaString;
    public bool checkStatus= false;
    [Range(-5,5)]
    public int value01;
    public int value02;
    public Animals animal;

    private void Update()
    {
       //CheckValue();
       CheckSwitchCase();
    }
    private void CheckValue()
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
    private void CheckSwitchCase()
    {
        switch(animal)
        {
            case Animals.Fish:
                Debug.Log("Pingo");
            break;
            case Animals.Cat:
                Debug.Log("Batatinha");
            break;
            case Animals.Dog:
                Debug.Log("Mel");
            break;
            default:
                Debug.Log("ESSE SER EU N CONHEÇO AINDA");
            break;

        }
    }


}
