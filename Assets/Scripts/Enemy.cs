using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int diff;
    public Transform target;

    void Start()
    {
        
    }

    void Update()
    {
        gameObject.transform.LookAt(target); //face player
        gameObject.transform.position += gameObject.transform.forward * (diff + 2) * Time.deltaTime;
    }
}
