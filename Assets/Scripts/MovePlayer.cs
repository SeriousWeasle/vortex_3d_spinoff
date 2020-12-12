using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    Camera view;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        view = GetComponent<Camera>(); //get camera from gameobject
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit; //make variable for hit
        Ray ray = view.ScreenPointToRay(Input.mousePosition); //ray that casts from camera at cursor position to level
        if (Physics.Raycast(ray, out hit)) //if it hits
        {
            player.transform.position = hit.point; //move player to mouse position
        }
    }
}
