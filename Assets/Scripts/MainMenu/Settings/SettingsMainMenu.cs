using UnityEngine;
using UnityEngine.Audio;

public class SettingsMainMenu : MonoBehaviour
{
    public AudioMixer audioMixer; 

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
        Debug.Log("Lauter..oder Leiser");

    }
}
