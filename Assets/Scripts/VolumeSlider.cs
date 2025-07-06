using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class VolumeSlider : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _mixerGroup;
    [SerializeField] private MixerGroupName _groupName;

    private float _minVolumeDb = -80;
    private Slider _slider;

    private void OnEnable()
    {
        _slider.onValueChanged.AddListener(ChangeVolume);
    }

    private void OnDisable()
    {
        _slider.onValueChanged.RemoveListener(ChangeVolume);
    }

    private void Awake()
    {
        _slider = GetComponent<Slider>();
    }

    public void ChangeVolume(float volume)
    {
        float volumeDb = Mathf.Log10(volume) * 20;

        if(volume == 0)
        {
            _mixerGroup.audioMixer.SetFloat(_groupName.ToString(), _minVolumeDb);
        }
        else
        {
            _mixerGroup.audioMixer.SetFloat(_groupName.ToString(), volumeDb);
        }
    }
}
