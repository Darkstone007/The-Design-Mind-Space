using UnityEngine;

[CreateAssetMenu(fileName = "MaterialChangerData", menuName = "ScriptableObjects/MaterialChangerData")]
public class MaterialChangerData : ScriptableObject
{
    public Material targetMaterial; // Reference to the material using the custom shader
    public Texture[] textures = new Texture[10]; // Array of 10 textures for each color property
}
