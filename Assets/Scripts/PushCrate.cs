using UnityEngine;

public class PushCrate : MonoBehaviour
{
    public Transform Spawn;

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Return))
        {
            ResetPosition();
        }

        MoveCrate();
    }

    private void MoveCrate()
    {
        transform.position += new Vector3(10 * Time.deltaTime, 0, 0);
        transform.Rotate(0, 200 * Time.deltaTime, 0, Space.World);
    }

    private void ResetPosition()
    {
        transform.SetPositionAndRotation(Spawn.position, Spawn.rotation);
    }
}
