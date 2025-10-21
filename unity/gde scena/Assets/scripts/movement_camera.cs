using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController: MonoBehaviour
{
    public float movespeed = 3;
    public static float horizontal_ad, vertical_ws;

    void start() {

    }

    void Update() {
        horizontal_ad = Input.GetAxis("Horizontal")*movespeed;
        vertical_ws = Input.GetAxis("Vertical")*movespeed;
        transform.Translate(horizontal_ad,0,0);
        transform.Translate(0,vertical_ws,vertical_ws);
    }
}