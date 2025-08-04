using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void NovaPartida()
    {
        SceneManager.LoadScene("Jogo");
    }

    public void Configuracoes()
    {
        Debug.Log("Abrir configurações...");
        // Aqui você pode criar um painel com abas de áudio, vídeo e controles
    }

    public void Creditos()
    {
        Debug.Log("Abrir créditos...");
    }

    public void Extras()
    {
        Debug.Log("Abrir extras...");
    }
}