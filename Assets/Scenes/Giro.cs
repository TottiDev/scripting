using UnityEngine;

public class Giro : MonoBehaviour
{

    private Transform _transform;
    [SerializeField] 
    private float degreesPerSecond = 5f;
    [SerializeField]
    private float scalePerSecond = 5f;

    void Awake()
    {
        Debug.Log("Awake");
        _transform = transform;
    }

    private void Start()
    {
        Debug.Log("Start");
    }
   
    void Update()
    {
        Debug.Log("Update");
        _transform.Rotate(0f, degreesPerSecond * Time.deltaTime, 0f);
    }
}
