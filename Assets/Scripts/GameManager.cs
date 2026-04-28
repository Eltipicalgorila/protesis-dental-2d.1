using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instancia;

    public float humanos;
    public float monstruos;

    void Awake()
    {
        if (instancia == null)
        {
            instancia = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}