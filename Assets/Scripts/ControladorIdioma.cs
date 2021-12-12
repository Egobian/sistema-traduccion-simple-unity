using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ControladorIdioma : MonoBehaviour
{
    // Se crea la lista que tendrá los scriptable objects de los idiomas
    public List<FicheroIdioma> IdiomasDisponibles = new List<FicheroIdioma>();

    // Elementos UI de la escena Inicial
    [Header("Escena Inicial")]
    public Text textoEscenaInicial;
    public Text textoOpciones;
    public Text textoSalir;

    // Elementos UI de la escena Ejemplo
    [Header("Escena Ejemplo")]
    public Text parrafo1;
    public Text parrafo2;
    public Text parrafo3;
    public Text parrafo4;
    public Text textoVolver;

    // Elementos UI de la escena Opciones
    [Header("Escena Opciones")]
    public Text textoIdiomaES;
    public Text textoIdiomaEN;
    public Text textoIdiomaFR;
    public Text textoGuardar;
    public Text textoResetearOpciones;


    // Variables privadas, idiomaGuardado se extrae de las playerPrefs
    private string idiomaGuardado;


    private void Start()
    {
        idiomaGuardado = PlayerPrefs.GetString("idioma", "");

        if (idiomaGuardado != string.Empty)
        {
            switch (idiomaGuardado)
            {
                case "Spanish":
                    Traducir(IdiomasDisponibles.Find(x => x.name == "Spanish"));
                    break;
                case "French":
                    Traducir(IdiomasDisponibles.Find(x => x.name == "French"));
                    break;
                default:
                    Traducir(IdiomasDisponibles.Find(x => x.name == "English"));
                    break;
            }
        }
        else
        {
            if (Application.systemLanguage == SystemLanguage.Spanish)
            {
                Traducir(IdiomasDisponibles.Find(x => x.name == "Spanish"));
            }
            else if (Application.systemLanguage == SystemLanguage.French)
            {
                Traducir(IdiomasDisponibles.Find(x => x.name == "French"));
            }
            else
            {
                Traducir(IdiomasDisponibles.Find(x => x.name == "English"));
            }
        }
    }




    private void Traducir(FicheroIdioma idioma)
    {
        string escenaActual;
        escenaActual = SceneManager.GetActiveScene().name;

        switch (escenaActual)
        {
            case "Inicial":
                textoEscenaInicial.text = idioma.textoSiguienteEscena;
                textoOpciones.text = idioma.textoOpciones;
                textoSalir.text = idioma.textoSalir;
                break;

            case "Ejemplo":
                parrafo1.text = idioma.parrafo1;
                parrafo2.text = idioma.parrafo2;
                parrafo3.text = idioma.parrafo3;
                parrafo4.text = idioma.parrafo4;
                textoVolver.text = idioma.textoVolver;
                break;

            case "Opciones":
                textoIdiomaES.text = idioma.textoIdiomaES;
                textoIdiomaEN.text = idioma.textoIdiomaEN;
                textoIdiomaFR.text = idioma.textoIdiomaFR;
                textoGuardar.text = idioma.textoGuardar;
                textoResetearOpciones.text = idioma.textoResetearOpciones;
                break;

            default:
                Debug.LogError("Ha ocurrido un error al traducir los elementos la escena");
                break;
        }
    }
}
