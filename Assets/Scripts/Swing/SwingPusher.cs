using UnityEngine;

public class SwingPusher : Pusher<Swing>
{
    [SerializeField] private Vector3 _forceAwakening;

    private void Update()
    {
        if (InpReader.GetInputPushingSwing() == true)
        {
            Push();
        }
    }

    protected override void Push()
    {
        SetAnchorPosition(PositionAnchor);
    }

    protected override void SetAnchorPosition(Vector3 position)
    {
        ObjectMovable.Rigdbody.AddForce(_forceAwakening);

        ObjectMovable.Joint.anchor = position;
    }
}
