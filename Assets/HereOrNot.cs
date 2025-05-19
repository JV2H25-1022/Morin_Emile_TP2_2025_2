using UnityEngine;

public class HereOrNot : MonoBehaviour
{

    public GameObject target;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (target != null)
                target.SetActive(!target.activeSelf);
            else
                target.SetActive(!target.activeSelf);
        }
    }
}