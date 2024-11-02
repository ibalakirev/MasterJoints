using UnityEngine;

public class ProjectileSpawner : MonoBehaviour
{
    [SerializeField] private CatapultPusher _launcher;
    [SerializeField] private Projectile _prefab;

    private void OnEnable()
    {
        _launcher.RechargeAllowed += Create;
    }

    private void OnDisable()
    {
        _launcher.RechargeAllowed -= Create;
    }

    private void Create(Vector3 position)
    {
        Instantiate(_prefab, position, Quaternion.identity);
    }
}
