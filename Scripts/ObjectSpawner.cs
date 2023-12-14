using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject[] objectsToSpawn; // Array holding 36 preexisting objects

    // Function to spawn an object based on index
    public void SpawnObject(int index)
    {
        if (index >= 0 && index < objectsToSpawn.Length)
        {
            // Spawn the selected object in front of the user (you might need to adjust the position)
            Vector3 spawnPosition = Camera.main.transform.position + Camera.main.transform.forward * 2f; // Adjust distance from camera
            GameObject spawnedObject = Instantiate(objectsToSpawn[index], spawnPosition, Quaternion.identity);

            // You might want to further position or manipulate the spawned object here if needed
        }
        else
        {
            Debug.LogWarning("Index out of range!");
        }
    }
}

