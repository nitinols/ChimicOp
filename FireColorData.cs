using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="FireColorData", menuName ="Data/FireColorData")]
public class FireColorData : ScriptableObject
{
    public List<MaterialFire> colors;
}


[System.Serializable]
public struct MaterialFire
{
    public string name;
    public Material material;
    public Color color;
}

public enum Material
{
    Metal, Plastic
}

