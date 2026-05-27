using UnityEngine;

public class SonidoBoton : MonoBehaviour
{
    public AudioSource audioSource;

    public void Click()
    {
        audioSource.Play();
    }
}