using UnityEngine;

public class SoundButton : MonoBehaviour
{
    [SerializeField] private AudioSource _sound;

    private bool _canPlay;

    private float _startSoundTime;
    private float _currentSoundTime;

    private void Awake()
    {
        _canPlay = true;
        _startSoundTime = _sound.clip.length;
    }

    private void Update()
    {
        if (_currentSoundTime <= 0)
        {
            _canPlay = true;
            _currentSoundTime = _startSoundTime;
        }
        else
        {
            _currentSoundTime -= Time.deltaTime;
        }
    }

    public void PlaySound()
    {
        if (_canPlay)
        {
            _sound.Play();
            _canPlay = false;
        }
    }
}
