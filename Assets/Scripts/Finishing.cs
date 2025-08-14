using UnityEngine;

public class Finishing : MonoBehaviour
{

    public string playerTag = "Player";

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(playerTag))
        {
            Debug.Log("Finish");
        }
    }
}
