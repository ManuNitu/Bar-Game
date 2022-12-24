using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bartender : MonoBehaviour
{
    public GameObject whiskyGlass;
    public void ThrowGlass()
    {
        whiskyGlass.SetActive(true);
    }
}
