using UnityEngine;

public class laser : MonoBehaviour
{
    public Transform enemy;
    public Transform player;
    Vector3 player_enemy_dist;
    void FixedUpdate()
    {
        player_enemy_dist = enemy.position - player.position; //calculate distance in 3 component vector between player and enemy
        Vector3 laserPos = enemy.transform.position - (player_enemy_dist / 2); //set position to in between player and enemy
        Vector3 laserScale = new Vector3(0.25f, 0.25f, player_enemy_dist.magnitude); //scale along z direction to distance
        gameObject.transform.position = laserPos; //set position
        gameObject.transform.localScale = laserScale; //set scale
    }
}