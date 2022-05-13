using UnityEngine;

class FrogFeedback : MonoBehaviour
{
    [SerializeField]
    private ParticleSystem moveParticles;

    private GroundDetector groundDetector;
    [SerializeField]
    private ParticleSystem landParticles;

    [SerializeField]
    private ParticleSystem jumpParticles;

    private void Awake()
    {
        groundDetector = GetComponent<GroundDetector>();
    }

    private void OnEnable()
    {
        groundDetector.Landed += LandFeedback;
        groundDetector.LeftGround += JumpFeedback;
    }

    private void OnDisable()
    {
        groundDetector.Landed -= LandFeedback;
        groundDetector.LeftGround -= JumpFeedback;
    }

    private void LandFeedback()
    {
        moveParticles.Play();
        landParticles.Play();
    }

    private void JumpFeedback()
    {
        jumpParticles.Play();
    }
}