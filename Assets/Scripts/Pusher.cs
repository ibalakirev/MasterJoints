using UnityEngine;

[RequireComponent(typeof(InputReader))]

public abstract class Pusher<T>: MonoBehaviour where T : MonoBehaviour
{
    [SerializeField] private T _objectMovable;
    [SerializeField] private Vector3 _positionAnchor;

    private InputReader _inputReader;

    protected T ObjectMovable => _objectMovable;
    protected InputReader InpReader => _inputReader;
    protected Vector3 PositionAnchor => _positionAnchor;

    private void Awake()
    {
        _inputReader = GetComponent<InputReader>();
    }

    protected abstract void Push();

    protected abstract void SetAnchorPosition(Vector3 position);
}
