using UnityEngine;

public class PushNade : MonoBehaviour
{
    public Vector3 Torque;
    public Rigidbody Rigidbody;
    public Transform SpawnPoint;

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Return))
        {
            ResetLocation();
            SendFlying();

            // enable gravity
            Rigidbody.useGravity = true;
        }
    }

    private void ResetLocation()
    {
        // place it back at spawn point
        transform.SetPositionAndRotation(SpawnPoint.position, SpawnPoint.rotation);

        // reset velocity
        Rigidbody.velocity = new Vector3(0, 0, 0);
        Rigidbody.angularVelocity = new Vector3(0, 0, 0);
    }

    private void SendFlying()
    {
        Rigidbody.AddForce(0, 0, 20, ForceMode.Impulse);
        Rigidbody.AddTorque(Torque, ForceMode.Impulse);
    }
}
