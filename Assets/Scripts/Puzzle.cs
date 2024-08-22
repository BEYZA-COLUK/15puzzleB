using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle : MonoBehaviour
{
    public int ID; //her bulmacaya özgü kimlik numarası

    public void Awake()
    {
        //boxcollider2d bileşenini etkinleştir
        GetComponent<BoxCollider2D>().enabled = true;
    }

    void ReplaceBlocks(int x, int y, int XX, int YY)
    {
        //blokları yeni pozisyona taşı ve eski pozisyonu boş bırak
        GameController.grid[x, y].transform.position = GameController.position[XX, YY];
        GameController.grid[XX, YY] = GameController.grid[x, y];
        GameController.grid[x, y] = null;
        GameController.GameFinish(); // oyunun bitip bitmediğini kontrol et
    }

    void OnMouseDown()
    {
        //tıklanan bloğun etrafındaki boş alanları kontrol et
        for (int y = 0; y < 4; y++)
        {
            for (int x = 0; x < 4; x++)
            {
                if (GameController.grid[x, y])
                {
                    if (GameController.grid[x, y].GetComponent<Puzzle>().ID == ID)
                    {
                        //bloğun solunda boş yer var mı kontrol et
                        if (x > 0 && GameController.grid[x - 1, y] == null)
                        {
                            ReplaceBlocks(x, y, x - 1, y);
                            return;
                        }
                        //bloğun sağında boş yer var mı kontrol et
                        else if (x < 3 && GameController.grid[x + 1, y] == null)
                        {
                            ReplaceBlocks(x, y, x + 1, y);
                            return;
                        }
                    }
                }
                if (GameController.grid[x, y])
                {
                    if (GameController.grid[x, y].GetComponent<Puzzle>().ID == ID)
                    {
                        //bloğun üstünde boş yer var mı kontrol et
                        if (y > 0 && GameController.grid[x, y - 1] == null)
                        {
                            ReplaceBlocks(x, y, x, y - 1);
                            return;
                        }
                        //bloğun altında boş yer var mı kontrol et
                        else if (y < 3 && GameController.grid[x, y + 1] == null)
                        {
                            ReplaceBlocks(x, y, x, y + 1);
                            return;
                        }
                    }
                }
            }
        }
    }
}
