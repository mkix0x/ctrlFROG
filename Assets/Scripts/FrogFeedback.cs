using MoreMountains.Feedbacks;
using UnityEngine;

internal class FrogFeedback : MonoBehaviour
{
    private GroundDetector groundDetector;

    [SerializeField]
    private MMF_Player landFeedback;

    [SerializeField]
    private MMF_Player jumpFeedback;

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