using UnityEngine;
using UnityEngine.SceneManagement;
public class PasarNivel : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void Nivel2()
    {
        SceneManager.LoadScene("Nivel2");
    }
    public void Nivel3()
    {
        SceneManager.LoadScene("Nivel3");
    }

}
