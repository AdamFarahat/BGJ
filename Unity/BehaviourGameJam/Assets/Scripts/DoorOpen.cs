using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AudioManager.instance.PlayOneShot(FMODEvents.instance.doorOpenEvent);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
