using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactor : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // if ..... 
        Debug.Log(Database.GetDatabase().colors[0]);
    }
}
