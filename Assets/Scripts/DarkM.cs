using UnityEngine;
using UnityEngine.UI; 

public class DarkMod : MonoBehaviour
{
    public Image backgroundImage; //arka plan resmi
    public Sprite initialBackgroundSprite; //ilk arka plan resmi
    public Sprite darkModeSprite; //dark mod arka plan resmi

    private bool isDarkMode = false; //dark modda olup olmad���m�z� izlemek i�in

    //buton t�kland���nda �a�r�lacak fonksiyon
    public void OnChangeBackgroundButtonClicked()
    {
        if (isDarkMode)
        {
            //e�er dark moddaysak ilk resme d�n
            backgroundImage.sprite = initialBackgroundSprite;
            isDarkMode = false;
        }
        else
        {
            //e�er dark modda de�ilsek dark mod resmine ge�
            backgroundImage.sprite = darkModeSprite;
            isDarkMode = true;
        }
    }
}
