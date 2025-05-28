using UnityEngine;

public class dontDestroy : MonoBehaviour
{
    public static dontDestroy Instance;

    // Example variable you want to keep
    public int objetTotalPris = 0;

    void Awake()
    {
        Debug.Log("dontDestroy Awake() called on " + gameObject.name);

        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            // Initialize your variables here if needed
            objetTotalPris = 0;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
