using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 20f; // скорость в метрах/сек

    void Start()
    {
        
    }

    void Update()
    {
        // Получаем входы
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Составляем вектор движения: X - влево/вправо, Z - вперёд/назад
        Vector3 move = new Vector3(horizontal, 0f, vertical) * moveSpeed * Time.deltaTime;

        // Перемещаем в мировых координатах (чтобы не учитывать локальную ориентацию)
        transform.Translate(move, Space.World);
    }
}