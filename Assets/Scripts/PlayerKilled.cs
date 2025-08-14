using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public string playerTag = "Player";
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(playerTag)) 
        {
            Destroy(collision.gameObject);
            Debug.Log("Player Killed");
        }
    }
}
