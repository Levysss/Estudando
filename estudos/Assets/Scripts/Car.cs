using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    
    #region VARIAVEIS
    private int doors = 4;
    public float life = 10;
    public float damege = 0.5f;
    protected bool acelerate = false;
    public GameObject myGameObject;
    private Transform myTransform;
    public Color color = Color.red;
    #endregion
    
    #region METODOS
    public void ChangeColor()
    {
        color = Color.blue;
        life -= damege;
    }

    void Start()
    {
        ChangeColor();
    }

    void Update()
    {
        
    }
    #endregion

}
