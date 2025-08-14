using UnityEngine;

public class Spinner : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField]private float rotationSpeed = 1.0f;


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,rotationSpeed,0);
    }
}
