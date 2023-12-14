using UnityEngine;

public class GameObjectActivator : MonoBehaviour
{
    // Function to activate a GameObject
    public void ActivateObject(GameObject objToActivate)
    {
        if (objToActivate != null)
        {
            objToActivate.SetActive(true);
        }
        else
        {
            Debug.LogError("The GameObject to activate is null!");
        }
    }

    // Function to deactivate a GameObject
    public void DeactivateObject(GameObject objToDeactivate)
    {
        if (objToDeactivate != null)
        {
            objToDeactivate.SetActive(false);
        }
        else
        {
            Debug.LogError("The GameObject to deactivate is null!");
        }
    }
}
