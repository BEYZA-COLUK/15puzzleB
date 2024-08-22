using UnityEngine;
using UnityEngine.UI;

public class VolumeControl : MonoBehaviour
{
    public AudioSource backgroundMusic; //ses kayna�� atamas� yap�lacak
    public Button plusButton;  //art� butonu atamas� yap�lacak
    public Button minusButton; //eksi butonu atamas� yap�lacak
    private float volume = 0.5f; // ba�lang�� ses seviyesi

    void Start()
    {
        backgroundMusic.volume = volume;// ses seviyesini ayarla

        //butonlara dinleyici ekle
        plusButton.onClick.AddListener(IncreaseVolume);
        minusButton.onClick.AddListener(DecreaseVolume);
    }

    void IncreaseVolume()
    {
        if (volume < 1f) //max volume 1
        {
            volume += 0.1f;
            backgroundMusic.volume = volume;
        }
    }

    void DecreaseVolume()
    {
        if (volume > 0f) //min volume 0
        {
            volume -= 0.1f;
            backgroundMusic.volume = volume;
        }
    }
}
