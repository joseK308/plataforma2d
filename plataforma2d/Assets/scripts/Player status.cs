using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    public int vidas = 3;
    public float energia = 100f; // Max = 100

    void Update()
    {
        // Exemplo de redução de energia
        if (Input.GetKeyDown(KeyCode.Space))
        {
            energia -= 10f;
            if (energia < 0) energia = 0;
        }
    }
}