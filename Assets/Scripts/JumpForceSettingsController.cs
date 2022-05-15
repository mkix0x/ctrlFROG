using UnityEngine;

internal class JumpForceSettingsController : SettingsController
{
    [SerializeField]
    private AutoJumper autoJumper;

    protected override void AddValue(float delta)
    {
        autoJumper.JumpForce += delta;
        text.SetText($"{autoJumper.JumpForce:0.0}");
    }
}