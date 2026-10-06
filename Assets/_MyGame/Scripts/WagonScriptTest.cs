using System.Runtime.CompilerServices;
using UnityEngine;

public class WagonScriptTest : MonoBehaviour
{
    [SerializeField] private int movementSpeed = 1;
    private void Update()
    {
        Vector2 inputVect = new Vector2(0, 0);
        if (Input.GetKey(KeyCode.W))
        {
            inputVect.y = + 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            inputVect.y = - 1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            inputVect.x = + 1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            inputVect.x = - 1;
        }
        inputVect = inputVect.normalized;
        Vector3 moveDir = new Vector3(inputVect.x, 0f, inputVect.y);
        transform.position += moveDir * Time.deltaTime * movementSpeed;
    }

}
