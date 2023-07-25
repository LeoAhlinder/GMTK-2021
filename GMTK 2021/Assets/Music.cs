using UnityEngine;

public class Music : MonoBehaviour
{
    private AudioSource _audioSource;
    private void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Music");
        if (objs.Length > 1)
            Destroy(this.gameObject);

        DontDestroyOnLoad(this.gameObject);
        _audioSource = GetComponent<AudioSource>();
    }
}