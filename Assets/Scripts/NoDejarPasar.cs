using UnityEngine;

public class NoDejarPasar : MonoBehaviour
{
    public ControlFrontera control;

    public void NoPasa()
    {
        control.NoDejarPasar();
    }
}
