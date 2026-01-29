using UnityEngine;

public class Player : MonoBehaviour
{
    public InputReader mainInputReader;
    
    private void Logic()
    {
        Debug.Log("Positive");
    }

    void OnEnable()
    {
        mainInputReader.OnPositiveInput += Logic;
    }

    void OnDisable()
    {
        mainInputReader.OnPositiveInput -= Logic;
    }
}
