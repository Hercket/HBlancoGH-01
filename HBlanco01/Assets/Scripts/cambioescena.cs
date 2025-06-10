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

    public void CerrarAplicaci�n()
    {
        Application.Quit();
        print("Aplicaci�n cerrada");
    }
}
