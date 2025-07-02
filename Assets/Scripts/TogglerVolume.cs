using UnityEngine;
using UnityEngine.Audio;

public class TogglerVolume : MonoBehaviour
{
    [SerializeField] private MixerGroupName _groupName;
    [SerializeField] private AudioMixerGroup _mixer;

    private float _minVolumeDb = -80f;
    private float _maxVolumeDb = 0f;

    public void ToggleVolume(bool enabled)
    {
        float masterVolume = enabled ? _maxVolumeDb : _minVolumeDb;

        _mixer.audioMixer.SetFloat(_groupName.ToString(), masterVolume);
    }
}
