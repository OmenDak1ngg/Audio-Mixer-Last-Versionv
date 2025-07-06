using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

[RequireComponent(typeof(Toggle))]
public class TogglerVolume : MonoBehaviour
{
    [SerializeField] private AudioListener _listener;

    private Toggle _toggle;

    private void OnEnable()
    {
        _toggle.onValueChanged.AddListener(ToggleVolume);
    }

    private void OnDisable()
    {
        _toggle.onValueChanged.RemoveListener(ToggleVolume);
    }

    private void Awake()
    {
        _toggle = GetComponent<Toggle>();
    }

    public void ToggleVolume(bool enabled)
    {
        _listener.enabled = enabled;
    }
}
