using UnityEngine;
public class ObjectActivator : MonoBehaviour
{
    public GameObject objectToActivate;

    public void ActivateObject()
    {
        if (objectToActivate != null)
        {
            objectToActivate.SetActive(true);
        }
    }

    public void DeactivateObject()
    {
        if (objectToActivate != null)
        {
            objectToActivate.SetActive(false);
        }
    }
}

