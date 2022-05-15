using UnityEngine;

internal class AirSpeedSettingsController : SettingsController
{
    [SerializeField]
    private FrogMover frogMover;

    protected override void AddValue(float delta)
    {
        frogMover.AirSpeed += delta;
        text.SetText($"{frogMover.AirSpeed:0.0}");
    }
}