using UnityEngine;

public class TriggerChest : MonoBehaviour
{
    public Chest chest;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Вызываем метод разрушения моста из скрипта Bridge
            chest.Open();
        }
    }
}