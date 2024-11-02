using UnityEngine;

public class SwingPusher : Pusher<Swing>
{
    [SerializeField] private Vector3 _forceAwakening;

    private void Update()
    {
        if (InpReader.GetInputPushingSwing() == true)
        {
            MoveAnchor();
        }
    }

    protected override void MoveAnchor()
    {
        ObjectMovable.Rigdbody.AddForce(_forceAwakening);

        SetAnchorPosition(PositionAnchor);
    }

    protected override void SetAnchorPosition(Vector3 position)
    {
        ObjectMovable.Joint.anchor = position;
    }
}
