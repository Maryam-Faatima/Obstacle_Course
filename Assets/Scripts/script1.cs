using UnityEngine;

public class script1 : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("MonoBehaviourCycle.Awake()");
    }

    //light laganay k liye
    private void OnEnable()
    {
        Debug.Log("MonoBehaviourCycle.OnEneable()");
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("MonoBehaviourCycle Start");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("MonoBehaviourCycle Update");
    }

    void FixedUpdate()
    {
        Debug.Log("MonoBehaviourCycle FixedUpdate");
    }

    void LateUpdate()
    {
        Debug.Log("MonoBehaviourCycle LateUpdate");
    }


    void OnDisable()
    {
        Debug.Log("MonoBehaviourCycle Disable");
    }

    void OnDestroy()
    {
        Debug.Log("MonoBehaviourCycle OnDestroy");
    }
}
