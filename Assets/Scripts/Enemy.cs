using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int diff; //dificulty int
    public float speedMult = 1; //speed at which movespeed increases/frame
    public float scaleMult = 0.04f; //speed at which target grows
    public Transform target; //point to move to

    float baseSpeed = 3f; //start speed
    public float scale { private set; get; } = 1f; //start scale

    public bool isDamaging = false;

    void FixedUpdate()
    {
        baseSpeed += (speedMult * Time.deltaTime); //boost movement speed
        gameObject.transform.LookAt(target); //face player
        if (isDamaging)
        {
            gameObject.transform.position += gameObject.transform.forward * -3f * Time.deltaTime; //push back
            if (scale > 0.5f) //if not smaller than half start size
            {
                scale -= 0.3f * Time.deltaTime;
            }
        }
        else
        {
            scale += scaleMult * (diff + 2) * Time.deltaTime; //boost scale
            gameObject.transform.position += gameObject.transform.forward * baseSpeed * (diff + 2) * Time.deltaTime; //move forward
        }
        gameObject.transform.localScale = new Vector3(scale, 1f, scale); //apply 3 component vector scale
    }
}
