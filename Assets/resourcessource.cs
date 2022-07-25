using UnityEngine;


public class resourcessource : MonoBehaviour
{
    public string resourceName;
    public float value;

    public void CollectResource(bool destroyObject)
    {
        playerresource2.Find(resourceName).ChangeValue(value);
        if (destroyObject)
        {
            Destroy(gameObject);
        }
    }
}