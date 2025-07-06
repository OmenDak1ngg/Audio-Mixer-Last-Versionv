using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class SoundButton : MonoBehaviour
{
    [SerializeField] private AudioSource _sound;

    private Button _button;

    private void OnEnable()
    {
        _button.onClick.AddListener(PlaySound);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(PlaySound);
    }

    private void Awake()
    {
        _button = GetComponent<Button>();
    }

    public void PlaySound()
    {
        _sound.PlayOneShot(_sound.clip);
    }
}
