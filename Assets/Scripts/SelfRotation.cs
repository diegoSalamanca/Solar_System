//Developed by Diego Salamanca
//phone: +57 3508232690
//email: Diegocolmayor@gmail.com

using UnityEngine;

public class SelfRotation : MonoBehaviour
{
    public float speed;     


    private void FixedUpdate()
    {
        transform.RotateAround(transform.position, Vector3.up, speed);

        
    }
}
