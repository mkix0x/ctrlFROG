using UnityEngine;

internal class JumpIntervalSettingsController : SettingsController
{
    [SerializeField]
    private AutoJumper autoJumper;

    protected override void AddValue(float delta)
    {
        autoJumper.Cooldown += delta;
        text.SetText($"{autoJumper.Cooldown:0.0}");
    }
}