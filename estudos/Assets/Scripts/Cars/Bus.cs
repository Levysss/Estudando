using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bus : MonoBehaviour
{
    #region Variable
    [Header("VARIABLES")]
    public int doors = 3;
    public Color color = Color.yellow;
    #endregion


    #region Methods
    private void Awake()
    {
        Init();
    }
    public void Init()
    {
        BusBase myBus = new BusBase(4,Color.blue);
    }
    #endregion

   
}

 public class BusBase
    {
        public int doors = 3;
        public Color color = Color.yellow;
        public BusBase()
        {
            Debug.Log("Construtor");
        }
        public BusBase(int doors,Color color)
        {
            this.doors = doors;
            this.color = color;
        }
    }