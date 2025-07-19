using UnityEngine;
using UnityEngine.Audio;

public class SettingsMainMenu : MonoBehaviour
{
    public AudioMixer audioMixer; 

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("Volume", volume);
        Debug.Log("Lauter..oder Leiser");

    }
}
