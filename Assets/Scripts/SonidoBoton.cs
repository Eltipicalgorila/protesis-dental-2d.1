using UnityEngine;

public class SonidoBoton : MonoBehaviour
{
    public AudioSource audioSource1, audioSource2;

    public void Click()
    {
        audioSource1.Play();
    }
    public void Clicke()
    {
        audioSource2.Play();
    }
}