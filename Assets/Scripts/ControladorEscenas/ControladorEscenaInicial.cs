using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorEscenaInicial : MonoBehaviour
{
    public void CargarEscenaEjemplo()
    {
        SceneManager.LoadScene("Ejemplo");
    }

    public void CargarEscenaOpciones()
    {
        SceneManager.LoadScene("Opciones");
    }

    public void Salir()
    {
        Application.Quit();
    }
}
