using UnityEngine;
using UnityEngine.SceneManagement;

public class Fina : MonoBehaviour
{
    public Vidas Resultado;
    public string Final;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (Resultado.VerResultadoFinal == 0)
        {
            Final = "FinalBueno";
        }
        if (Resultado.VerResultadoFinal == 1 || Resultado.VerResultadoFinal == 2)
        {
            Final = "FinalMedio";
        }
        if (Resultado.VerResultadoFinal == 3)
        {
            Final = "FinalMalo";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SeAcabo()
    {
        Debug.Log("Has sacado el " + Final);
    }
}
