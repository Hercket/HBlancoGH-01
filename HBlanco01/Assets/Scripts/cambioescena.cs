using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
{
    public void CambiarEscena(string Escena)
    {
        SceneManager.LoadScene(Escena);
    }

    public void CerrarAplicación()
    {
        Application.Quit();
        print("Aplicación cerrada");
    }
}
