using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorEscenaEjemplo : MonoBehaviour
{
    public void CargarEscenaInicial()
    {
        SceneManager.LoadScene("Inicial");
    }

}
