using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public GameObject panelFondo;       
    public GameObject panelOpciones;    

    public void Jugar()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void Opciones()
    {
        panelFondo.SetActive(false);          
        panelOpciones.SetActive(true);        
    }

    public void Volver()
    {
        panelOpciones.SetActive(false);       
        panelFondo.SetActive(true);           
    }

    public void Salir()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
