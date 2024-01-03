using UnityEngine;
using System;

public class PickUpPotion : MonoBehaviour
{
    public bool isPotionDestroyed { get; private set; }

    // Объявление события, которое будет вызываться при уничтожении зелья
    public event Action potionDestroyed;

    // Вызывается, когда другой коллайдер входит в триггер
    private void OnTriggerEnter(Collider other)
    {
        // Проверяем, вошел ли другой коллайдер с тегом "Player"
        if (other.CompareTag("Player"))
        {
            // Уничтожаем объект, к которому прикреплен этот скрипт (зелье)
            Destroy(gameObject);
            isPotionDestroyed = true;

            // Вызываем событие о том, что зелье было уничтожено
            potionDestroyed?.Invoke();
        }
    }
}