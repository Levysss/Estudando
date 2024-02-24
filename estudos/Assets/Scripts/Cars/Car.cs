using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    
    #region VARIAVEIS

    [Header("Variaves")]
    public int doors = 4;
    public float life = 10;
    public float damege = 0.5f;
    public bool canAcelerate = false;

    [Header("Colors")]
    public Color color = Color.red;

    [Header("Imputs")]
    public KeyCode keyCode = KeyCode.Space;
    //privadas dps das publicas
    private GameObject myGameObject;
    private Transform myTransform;
    #endregion
    
    #region METODOS
    public void ChangeColor(Color newColor)
    {
        color = newColor;
        life -= damege;
    }
    //---------------------------
    
    void Awake()
    {
    
    }
    void Start()
    {
       
    }

    void Update()
    {
        if(Input.GetKeyDown(keyCode))
        {
            ChangeColor(Color.yellow);
        }
        else if(Input.GetKeyUp(keyCode))
        {
            ChangeColor(Color.red);
        }
        else if(Input.GetKey(KeyCode.W))
        {
            ChangeColor(Color.black);
        }

        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse down");
        }

        if(Input.GetButtonDown("Fire1"))
        {

        }
    }
    
    #endregion

}
