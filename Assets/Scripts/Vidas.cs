using UnityEngine;

public class Vidas : MonoBehaviour
{
    public GameObject aciertos, inaciertos;
    public Letras montruo;
    public static float resultadoFinal;
    public float VerResultadoFinal;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (montruo.Monstruos <= 0 & montruo.Humanos == 3)
        {
            aciertos.gameObject.SetActive(true);
            Debug.Log("Buena");
        }
        else
        {
            inaciertos.gameObject.SetActive(true);
            Debug.Log("Mala");
            resultadoFinal = resultadoFinal + 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        VerResultadoFinal = resultadoFinal;
    }
    public void Reinicio()
    {
        resultadoFinal = 0;
    }
}
