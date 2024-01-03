using UnityEngine;

public class Player : MonoBehaviour
{
    // Переменная для хранения компонента Outline
    public Outline playerOutline;

    private PickUpPotion pickUpPotion;

    // Вызывается при запуске скрипта
    private void Start()
    {
        // Получаем ссылку на скрипт PickUpPotion на том же объекте
        pickUpPotion = GetComponent<PickUpPotion>();

        // Подписываемся на событие "potionDestroyed" скрипта PickUpPotion
        pickUpPotion.potionDestroyed += ChangeOutlineWidth;
    }

    // Вызывается каждый кадр
    private void Update()
    {
        // Проверяем, если зелье было уничтожено
        if (pickUpPotion != null && pickUpPotion.isPotionDestroyed)
        {
            // Вызываем метод изменения ширины контура игрока
            ChangeOutlineWidth();
        }
    }

    // Метод для изменения ширины контура игрока
    private void ChangeOutlineWidth()
    {
        // Проверяем, что компонент Outline объекта Player существует
        if (playerOutline != null)
        {
            playerOutline.OutlineWidth = 2;
        }
    }
}