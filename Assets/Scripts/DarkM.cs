using UnityEngine;
using UnityEngine.UI; 

public class DarkMod : MonoBehaviour
{
    public Image backgroundImage; //arka plan resmi
    public Sprite initialBackgroundSprite; //ilk arka plan resmi
    public Sprite darkModeSprite; //dark mod arka plan resmi

    private bool isDarkMode = false; //dark modda olup olmadýðýmýzý izlemek için

    //buton týklandýðýnda çaðrýlacak fonksiyon
    public void OnChangeBackgroundButtonClicked()
    {
        if (isDarkMode)
        {
            //eðer dark moddaysak ilk resme dön
            backgroundImage.sprite = initialBackgroundSprite;
            isDarkMode = false;
        }
        else
        {
            //eðer dark modda deðilsek dark mod resmine geç
            backgroundImage.sprite = darkModeSprite;
            isDarkMode = true;
        }
    }
}
