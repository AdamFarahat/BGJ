using UnityEngine;
using FMODUnity;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    
    public void PlayOneShot(EventReference eventReference)
    {
        Debug.Log("Playing sound: " + eventReference);
        RuntimeManager.PlayOneShot(eventReference);
    }
}
