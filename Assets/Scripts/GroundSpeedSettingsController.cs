using UnityEngine;

internal class GroundSpeedSettingsController : SettingsController
{
    [SerializeField]
    private FrogMover frogMover;

    protected override void AddValue(float delta)
    {
        frogMover.GroundSpeed += delta;
        text.SetText($"{frogMover.GroundSpeed:0.0}");
    }
}