using UnityEngine;

public class InstantiatePrefab : MonoBehaviour
{
    public GameObject myPrefab; // Reference to the prefab in the Inspector

    void Start()
    {
        // Check if the myPrefab is assigned
        if (myPrefab != null)
        {
            // Instantiate the prefab at a specific position and rotation
            Instantiate(myPrefab, new Vector3(0f, 0f, 0f), Quaternion.identity);
            // You can change the position and rotation values (Vector3 and Quaternion) as needed
        }
        else
        {
            Debug.LogError("Prefab is not assigned!");
        }
    }
}
