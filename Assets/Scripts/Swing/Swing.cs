using UnityEngine;

[RequireComponent(typeof(HingeJoint), typeof(Rigidbody))]

public class Swing : MonoBehaviour
{
    private HingeJoint _joint;
    private Rigidbody _rigidbody;

    public Rigidbody Rigdbody => _rigidbody;
    public HingeJoint Joint => _joint;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _joint = GetComponent<HingeJoint>();
    }
}
