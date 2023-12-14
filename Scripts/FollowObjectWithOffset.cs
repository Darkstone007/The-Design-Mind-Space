using UnityEngine;

public class FollowObjectWithOffset : MonoBehaviour
{
    public Transform targetObject; // Reference to the object to follow
    public Vector3 offset = new Vector3(0f, 2f, 0f); // Offset values (you can adjust these in the Inspector)

    // Update is called once per frame
    void Update()
    {
        // Check if the target object is assigned
        if (targetObject != null)
        {
            // Set the position of this object to match the position of the target object with an offset
            transform.position = targetObject.position + offset;
        }
        else
        {
            Debug.LogError("Target object is not assigned!");
        }
    }
}
