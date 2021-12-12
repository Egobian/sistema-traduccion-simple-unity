using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorEscenaOpciones : MonoBehaviour
{

    // Elegimos el idioma que asignaremos a la PlayerPref idioma
    public void SeleccionarIdioma(string idiomaSeleccionado)
    {
        PlayerPrefs.SetString("idioma", idiomaSeleccionado);
    }


    // Guardamos las opciones seleccionadas y volvemos al menu inicial
    public void Guardar()
    {
        PlayerPrefs.Save();
        SceneManager.LoadScene("Inicial");
    }

    // Se elimina toda la informacion de las PlayerPrefs y volvemos al menu inicial
    public void ResetearOpciones()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene("Inicial");
    }

}
