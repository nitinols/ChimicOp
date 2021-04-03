using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class material : MonoBehaviour, ChemicalElem, ChemicFire
{

    public void combustion()
    {
        Destroy(this.gameObject);
    }

    public Color GetFireColor()
    {
        return Color.white;
    }

    public Color GetSparksColor()
    {
        return Color.white;
    }
}
