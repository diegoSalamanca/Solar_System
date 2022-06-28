//Developed by Diego Salamanca
//phone: +57 3508232690
//email: Diegocolmayor@gmail.com


using UnityEngine;

public class CameraController : MonoBehaviour
{

    public Cinemachine.CinemachineVirtualCamera[] cameras;

    public void SetPriority(int index)
    {
        foreach (var item in cameras)
        {
            item.Priority = 0;
        }
        
        cameras[index].Priority = 1;
    }
   
    void Start()
    {
        SetPriority(0);
    }

    
}
