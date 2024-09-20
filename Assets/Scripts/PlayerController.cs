using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CommandManager CommandManager;
    public float movementSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetAxisRaw("Horizontal") != 0)
        {
            ICommand horAxis = new MoveCommand(transform, Vector3.right* ((Input.GetAxisRaw("Horizontal") * Time.deltaTime) * movementSpeed));
            CommandManager.ExecuteCommand(horAxis);
        }
        if (Input.GetAxisRaw("Vertical") !=0)
        {
            ICommand vertAxis = new MoveCommand(transform, Vector3.up * ((Input.GetAxisRaw("Vertical") * Time.deltaTime)*movementSpeed));
            CommandManager.ExecuteCommand(vertAxis);
        }
        if (Input.GetKey(KeyCode.Z))
        {
            CommandManager.UndoLastCommand();
        }
    }
}
