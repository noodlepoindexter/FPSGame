using UnityEngine;

public class MAudioArea : MonoBehaviour
{
    
    [SerializeField]
    private AudioSource areaMusic;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if(!areaMusic.isPlaying)
            {
                areaMusic.Play();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if(areaMusic.isPlaying)
            {
                areaMusic.Stop();
            }
        }
    }
}
