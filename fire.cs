using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{
    ChemicalElem color = new material();

    public Color standart_fire;
    public Color standart_spark;
    private List<Renderer> child;

    private void Start()
    {
        standart_fire = this.gameObject.GetComponent<Renderer>().material.color;
        child = this.gameObject.GetComponentsInChildren<Renderer>();

    private void OnTriggerEnter(Collider other)
    {
        
    }

    private void StandartColor(int time)
    {

    }
}
