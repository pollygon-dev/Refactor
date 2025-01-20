using UnityEngine;

public class WallCollider : MonoBehaviour
{
    [Header("Collision")]
    [SerializeField] LayerMask WallLayer;

    private effects Fx;

    private void Awake()
    {
        Fx = GetComponent<effects>();
    }
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if ((WallLayer.value & (1 << hit.gameObject.layer)) > 0)
        {
            Fx.PlayAudio();
            Fx.ParticleEffect();
        }
    }
}
