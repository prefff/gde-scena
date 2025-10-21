using UnityEngine;
using UnityEngine.InputSystem;


[ExecuteAlways] 
public class MobaStyleCamera : MonoBehaviour
{
    public Transform target;           
    public float distance = 16f;       
    [Range(10f, 80f)]
    public float pitch = 50f;         
    [Range(0f, 360f)]
    public float yaw = 135f;            
    public float forwardOffset = 2f;   
    public float heightOffset = 20f;  
    public float smoothTime = 0.08f;   

    private Vector3 velocity = Vector3.zero;

    void LateUpdate()
    {
        if (target == null) return;

        
        Vector3 forward = Vector3.zero;
       
        forward = target.forward * forwardOffset;

        Vector3 focus = target.position + Vector3.up * heightOffset + forward;

        // вращение камеры: наклон (pitch) и поворот (yaw)
        Quaternion rot = Quaternion.Euler(pitch, yaw, 0f);

      
        Vector3 desiredPos = focus - (rot * Vector3.forward) * distance;

        // плавный перенос позиции
        if (smoothTime > 0f)
            transform.position = Vector3.SmoothDamp(transform.position, desiredPos, ref velocity, smoothTime);
        else
            transform.position = desiredPos;

        // камера смотрит на фокусную точку
        transform.rotation = Quaternion.LookRotation(focus - transform.position, Vector3.up);
    }
}