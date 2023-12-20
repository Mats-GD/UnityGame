using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField]
    private Rigidbody rb;

    // We marked this as Fixed update because
    // we are using it for physics
    void FixedUpdate()
    {
        rb.AddForce(0, 0, 2000 * Time.deltaTime);
    }
}