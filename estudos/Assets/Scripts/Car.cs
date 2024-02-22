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
    //---------------------------
    void Awake()
    {
        Debug.Log("Aweke foi chamado");
    
    }
    void Start()
    {
        Debug.Log("Start foi chamado!");
        ChangeColor();
    }

    void Update()
    {
        Debug.Log("update");
    }
    private void LateUpdate()
    {
        Debug.Log("Late Update ativo");
    }
    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate ativo");
    }
    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }
    private void OnDisable()
    {
        Debug.Log("OnDisable");
    }
    private void OnDestroy()
    {
        Debug.Log("OnDestroy");
    }
    #endregion

}
