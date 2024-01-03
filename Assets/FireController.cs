using UnityEngine;
using UnityEngine.Serialization;

public class FireController : MonoBehaviour
{
     public GameObject fireGameObject; // Присвойте объект огня в редакторе Unity

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            fireGameObject.SetActive(true);
           
        }
    }
}