using UnityEngine;

public class TextureChanger : MonoBehaviour
{
    public Texture[] textures = new Texture[10]; // Array of 10 textures

    public Renderer objectRenderer; // Reference to the GameObject's renderer

    // Function to change texture of the GameObject based on the selected texture index
    public void ChangeObjectTexture(int textureIndex)
    {
        if (textureIndex >= 0 && textureIndex < textures.Length)
        {
            if (objectRenderer != null)
            {
                objectRenderer.material.mainTexture = textures[textureIndex];
            }
            else
            {
                Debug.LogWarning("Renderer component not found!");
            }
        }
        else
        {
            Debug.LogWarning("Invalid texture index!");
        }
    }
}
