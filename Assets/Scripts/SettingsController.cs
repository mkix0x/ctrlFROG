using TMPro;
using UnityEngine;
using UnityEngine.UI;

internal abstract class SettingsController : MonoBehaviour
{
    [SerializeField]
    private Button plus, minus;

    [SerializeField]
    protected TMP_Text text;

    [SerializeField]
    private float interval = .5f;

    private void Start()
    {
        AddValue(0);
    }

    private void OnEnable()
    {
        plus.onClick.AddListener(() => AddValue(interval));
        minus.onClick.AddListener(() => AddValue(-interval));
    }

    protected abstract void AddValue(float delta);
}