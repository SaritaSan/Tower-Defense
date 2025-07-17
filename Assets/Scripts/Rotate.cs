using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField]
    private Vector3 _rotationspeed = new Vector3(0, 10f, 0);
 
    void Update()
    {
        transform.Rotate(_rotationspeed * Time.deltaTime, Space.Self);
    }
}
