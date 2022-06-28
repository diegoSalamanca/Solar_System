//Developed by Diego Salamanca
//phone: +57 3508232690
//email: Diegocolmayor@gmail.com

using UnityEngine;

public class Orbit : MonoBehaviour
{
    Transform solarSystemCenter;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        solarSystemCenter = GameObject.Find("SystemCenter").transform;
    }
   

    private void FixedUpdate() {

        transform.RotateAround(solarSystemCenter.position, Vector3.up, speed);
        
    }
}
