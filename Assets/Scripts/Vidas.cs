using UnityEngine;

public class Vidas : MonoBehaviour
{
    public GameObject aciertos, inaciertos;
    public Letras montruo;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (montruo.Monstruos <= 0)
        {
            aciertos.gameObject.SetActive(true);
            Debug.Log("Buena");
        }
        else
        {
            inaciertos.gameObject.SetActive(true);
            Debug.Log("Mala");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
