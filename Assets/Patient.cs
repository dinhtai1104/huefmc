using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patient : Singleton<Patient>
{
    public GameObject tShirt;


    public void SetTShirtActive(bool active)
    {
        tShirt.SetActive(active);
    }
}
