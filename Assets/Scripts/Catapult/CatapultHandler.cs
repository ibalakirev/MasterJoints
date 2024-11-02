using System;
using UnityEngine;

public class CatapultHandler : MonoBehaviour
{
    private float _counterCollisions = 0f;

    public event Action CollisionDetected;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out ReloadZone reloadZone))
        {
            IncreaseCounter—ollisions();

            TryReportCollision();
        }
    }

    private void TryReportCollision()
    {
        float maxValueCollisions = 1f;

        if (_counterCollisions == maxValueCollisions)
        {
            CollisionDetected?.Invoke();
        }
    }

    public void ResetCounter—ollisions()
    {
        float minValueCollisions = 0f;

        _counterCollisions = minValueCollisions;
    }

    private void IncreaseCounter—ollisions()
    {
        _counterCollisions++;
    }
}
