using UnityEngine;

public class LookAtEnemy : MonoBehaviour
{
    public Transform enemy;
    void Update()
    {
        gameObject.transform.LookAt(enemy); //make gameobject face enemy
    }
}
