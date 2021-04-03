using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface ChemicalElem
{
    Color GetFireColor();
    Color GetSparksColor();
}

interface ChemicFire
{
    void combustion();
}
