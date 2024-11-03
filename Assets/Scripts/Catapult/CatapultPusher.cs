using System;
using UnityEngine;

[RequireComponent(typeof(CatapultHandler))]

public class CatapultPusher : Pusher<Catapult>
{
    [SerializeField] private ProjectileSpawnPoint _projectileSpawnPosition;

    private CatapultHandler _catapulthandler;
    private Vector3 _difaultAnchorPosition;

    public event Action<Vector3> RechargeAllowed;

    private void Start()
    {
        _difaultAnchorPosition = ObjectMovable.Joint.anchor;
    }

    private void OnEnable()
    {
        _catapulthandler = GetComponent<CatapultHandler>();

        _catapulthandler.CollisionDetected += ReportReadinessRecharge;
    }

    private void OnDisable()
    {
        _catapulthandler.CollisionDetected -= ReportReadinessRecharge;
    }

    private void Update()
    {
        if (InpReader.GetInputPushingCatapult() == true)
        {
            MoveAnchor();
        }

        if (InpReader.GetInputRechargeCatapult() == true)
        {
            ReturnStartingPosition();
        }
    }

    protected override void SetAnchorPosition(Vector3 position)
    {
        ObjectMovable.Joint.anchor = position;
    }

    protected override void MoveAnchor()
    {
        _catapulthandler.ResetCounter—ollisions();

        SetAnchorPosition(PositionAnchor);
    }

    private void ReturnStartingPosition()
    {
        SetAnchorPosition(_difaultAnchorPosition);
    }

    private void ReportReadinessRecharge()
    {
        RechargeAllowed?.Invoke(_projectileSpawnPosition.transform.position);
    }
}
