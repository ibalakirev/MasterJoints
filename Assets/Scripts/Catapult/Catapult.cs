using UnityEngine;

[RequireComponent(typeof(SpringJoint), typeof(Rigidbody))]

public class Catapult : MonoBehaviour
{
    private SpringJoint _joint;
    private Rigidbody _rigidbody;

    public Rigidbody Rigdbody => _rigidbody;
    public SpringJoint Joint => _joint;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _joint = GetComponent<SpringJoint>();
    }
}
