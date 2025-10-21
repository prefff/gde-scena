using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 20f; // �������� � ������/���

    void Start()
    {
        
    }

    void Update()
    {
        // �������� �����
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // ���������� ������ ��������: X - �����/������, Z - �����/�����
        Vector3 move = new Vector3(horizontal, 0f, vertical) * moveSpeed * Time.deltaTime;

        // ���������� � ������� ����������� (����� �� ��������� ��������� ����������)
        transform.Translate(move, Space.World);
    }
}