using UnityEngine;
using UnityEngine.SceneManagement;
public class CambioEscenaMenu : MonoBehaviour
{
    public Vidas Resultado;
    public string Final;
    public float CuantoMostruosEntraron;
    public string Ilerna;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Resultado.VerResultadoFinal);
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
    public void Play()
    {
        SceneManager.LoadScene("Nivel1");
    }
    public void Leave()
    {
        SceneManager.LoadScene(Ilerna);
    }
    public void Level2()
    {
        SceneManager.LoadScene("Nivel2");
    }
    public void Level3()
    {
        SceneManager.LoadScene("Nivel3");
    }
    public void SeAcabo()
    {
        SceneManager.LoadScene(Final);
    }
    public void Inicio()
    {
        SceneManager.LoadScene("Capitulo 1 escena");
    }
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
