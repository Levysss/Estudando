using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float life;
    [SerializeField]private float damege;

    protected virtual void Init(){}

    public virtual void Attack()
    {
        Debug.Log("Attack: "+damege);
    }
    
}    
