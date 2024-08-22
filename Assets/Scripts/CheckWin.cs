using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckWin : MonoBehaviour
{
    private int sum = 0; //inversion sayısını tutar
    private int zero = 0; //boş hücrenin konumunu tutar
    int[] row_board = new int[16] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 15, 14, 0 }; //başlangıç tahtası dizisi

    public void Start()
    {
        //başlangıçta yapılacak işlemler için burada bir şey tanımlanmadı
    }

    public int[] Shuffle(bool check)
    {
        int tmp;
        if (check == true)
        {
            print("possibility=true"); //eğer çözüm mümkünse
            return row_board; //mevcut tahtayı döndür
        }
        else
        {
            print("possibility=false"); //eğer çözüm mümkün değilse
            //tahtayı karıştır
            for (int i = 15; i > 0; i--)
            {
                int j = UnityEngine.Random.Range(0, 16);
                tmp = row_board[i];
                row_board[i] = row_board[j];
                row_board[j] = tmp;
            }

            return row_board; //karıştırılmış tahtayı döndür
        }
    }

    public void Possibility(int[] mas)
    {
        //inversion sayısını ve boş hücrenin yerini hesapla
        for (int i = 0; i < 16; i++)
        {
            if (mas[i] == 0)
            {
                zero = i / 4 + 1; //boş hücrenin satırını hesapla
            }
            else
            {
                for (int k = i; k < 16; k++)
                {
                    if (mas[i] > mas[k] && mas[k] != 0)
                    {
                        sum++; //inversion sayısını artır
                    }
                }
            }
        }

        //inversion ve boş hücre pozisyonlarını yazdır
        for (int i = 0; i < 16; i++)
        {
            print("mas   " + mas[i]);
        }

        print("sum - " + sum + " zero - " + zero);
        //çözümün mümkün olup olmadığını kontrol et
        if ((zero + sum) % 2 == 0)
        {
            UnityEngine.Debug.Log("solution"); //çözüm mümkün
            Shuffle(true);
        }
        else
        {
            UnityEngine.Debug.Log("no solution"); //çözüm mümkün değil
            Shuffle(false);
        }
    }
}
