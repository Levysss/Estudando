using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MeuJogo.Bus.Maneger
{
public class BusManeger : MonoBehaviour
{
   public BusSetup[] busSetups;
}
[System.Serializable]
public class BusSetup
{
    public GameObject bus;
    public int doors;
}
}