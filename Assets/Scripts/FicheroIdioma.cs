using UnityEngine;

// Este atributo permite crear un nuevo tipo de dato en el menú de Unity
[CreateAssetMenu(menuName = "ScriptableObjects/FicheroIdioma", fileName = "Fichero idioma")]
public class FicheroIdioma : ScriptableObject
{
    // Elementos referentes a la escena "Inicial"
    [Header("Escena inicial")]
    public string textoSiguienteEscena;
    public string textoOpciones;
    public string textoSalir;

    // Elementos referentes a la escena "Ejemplo"
    [Header("Escena ejemplo")]
    public string parrafo1;
    public string parrafo2;
    public string parrafo3;
    public string parrafo4;
    public string textoVolver;

    // Elementos referentes a la escena "Opciones"
    [Header("Escena opciones")]
    public string textoIdiomaES;
    public string textoIdiomaFR;
    public string textoIdiomaEN;
    public string textoGuardar;
    public string textoResetearOpciones;

}

