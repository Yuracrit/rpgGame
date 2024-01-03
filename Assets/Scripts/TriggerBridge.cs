using UnityEngine;

public class TriggerBridge : MonoBehaviour
{
    public Bridge bridge;
    public PickUpPotion potionScript; // Ссылка на скрипт PickUpPotion

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Проверяем, если зелье еще не уничтожено, то разрушаем мост
            if (!potionScript.isPotionDestroyed)
            {
                bridge.Break();
            }
        }
    }
}