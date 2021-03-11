using UnityEngine;
using System.Collections;


public class BoxManager : MonoBehaviour
{
    public GameObject Boxing;
    public GameObject feet;
    public GameObject bos;
    public int kutu=0;
    public GameObject[] dene;
    public GameObject replay;
 
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Kutu")
        {
            gameObject.transform.position = gameObject.transform.position += new Vector3(0, 1, 0);
            Destroy(other.gameObject);
            kutuNew();
        }

        if (other.gameObject.tag=="enemy")
        {
            dene = GameObject.FindGameObjectsWithTag("Tasi");
            if (dene.Length > 1)
            {
                for (int i = 0; i < 1; i++)
                {
                    Destroy(dene[i]);
                }
            }
            else
            {
                Time.timeScale = 0f;
                replay.SetActive(true);
            }

        }
        else if (other.gameObject.tag=="enemy2")
        {
            dene = GameObject.FindGameObjectsWithTag("Tasi");
            if (dene.Length > 2)
            {
                for (int i = 0; i < 2; i++)
                {
                    Destroy(dene[i]);
                }
            }
            else
            {
                Time.timeScale = 0f;
                replay.SetActive(true);
            }

        }
        else if (other.gameObject.tag == "enemy3")
        {
            dene = GameObject.FindGameObjectsWithTag("Tasi");
            if (dene.Length > 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    Destroy(dene[i]);
                }
            }
            else
            {
                Time.timeScale = 0f;
                replay.SetActive(true);
            }

        }
        else if (other.gameObject.tag == "enemy4")
        {
            dene = GameObject.FindGameObjectsWithTag("Tasi");
            if (dene.Length > 4)
            {
                for (int i = 0; i < 4; i++)
                {
                    Destroy(dene[i]);
                }
            }
            else
            {
                Time.timeScale = 0f;
                replay.SetActive(true);
            }

        }
        else if (other.gameObject.tag == "enemy5")
        {
            dene = GameObject.FindGameObjectsWithTag("Tasi");
            if (dene.Length > 5)
            {
                for (int i = 0; i < 5; i++)
                {
                    Destroy(dene[i]);
                }
            }
            else
            {
                Time.timeScale = 0f;
                replay.SetActive(true);
            }
        }
    }

    //Çalışmıyor
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag=="Bitis")
        {
            for (int i = 0; i < 100; i++)
            {
                if (dene.Length < 1)
                {
                    Time.timeScale = 0f;
                    replay.SetActive(true);
                }
                else
                {
                    Destroy(dene[i]);
                }
                StartCoroutine(Bitis());
            }
        }
    }


    IEnumerator Bitis()
    {
        yield return new WaitForSeconds(1f);
       
    }
    //*******LAV SİSTEMİ ÇALIŞMIYOR********
    //IEnumerator LavBekle()
    //{
    //    for (int i = 0; i < 100; i++)
    //    {
    //        if (dene.Length < 1)
    //        {
    //            Time.timeScale = 0f;
    //            replay.SetActive(true);
    //        }
    //        else
    //        {
    //            Time.timeScale = 0f;
    //            replay.SetActive(true);
    //        }
    //        yield return new WaitForSeconds(0.7f);
    //        Destroy(dene[i]);
    //        yield return new WaitForSeconds(0.7f); 
    //    }
    //}
    //private void OnTriggerStay(Collider other)
    //{
    //    if (other.gameObject.tag == "lav")
    //    {
    //        dene = GameObject.FindGameObjectsWithTag("Tasi");
    //        if (dene.Length > 1)
    //        {
    //            StartCoroutine(LavBekle());
    //        }
    //    }
    //}
    //*******LAV SİSTEMİ ÇALIŞMIYOR********


    public void kutuNew()
    {
        feet.transform.position += new Vector3(0, kutu);
        //Parent olarak üretiyor böyle
        GameObject Parent = Instantiate(Boxing, feet.transform.position, Quaternion.identity) as GameObject;
        Parent.transform.SetParent(bos.transform);
        kutu = -1;
    }
}
