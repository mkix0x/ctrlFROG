using MoreMountains.Feedbacks;
using UnityEngine;

internal class FrogFeedback : MonoBehaviour
{
    [SerializeField]
    private MMF_Player landFeedback;

    [SerializeField]
    private MMF_Player jumpFeedback;

    private GroundDetector groundDetector;

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
        landFeedback.PlayFeedbacks();
    }

    private void JumpFeedback()
    {
        jumpFeedback.PlayFeedbacks();
    }
}