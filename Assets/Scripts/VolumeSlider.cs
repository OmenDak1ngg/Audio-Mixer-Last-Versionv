using UnityEngine;
using UnityEngine.Audio;

public class VolumeSlider : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _mixerGroup;
    [SerializeField] private MixerGroupName _groupName;

    private float _minVolumeDb = -80;

    public void ChangeVolume(float volume)
    {
        if(volume == 0)
        {
            _mixerGroup.audioMixer.SetFloat(_groupName.ToString(), _minVolumeDb);
        }
        else
        {
            _mixerGroup.audioMixer.SetFloat(_groupName.ToString(), Mathf.Log10(volume) * 20);
        }
    }
}
