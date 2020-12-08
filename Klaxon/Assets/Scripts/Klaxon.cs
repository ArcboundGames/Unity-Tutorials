using UnityEngine;

public class Klaxon : MonoBehaviour
{
    public float Speed = 1;

    private void Update()
    {
        transform.Rotate(new Vector3(0, 0, Speed), Space.Self);
    }
}
