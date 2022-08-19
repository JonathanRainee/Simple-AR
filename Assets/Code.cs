using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Code : MonoBehaviour
{
    public static Code instance;
    public int idx;
    public GameObject[] fruits;
    public GameObject placeHolder;
    public AudioClip[] fruitsSound;
    AudioSource sounds;

    public GameObject cherry;
    public GameObject banana;
    public GameObject lemon;
    public GameObject strawberry;

    public GameObject cherryHolder;
    public GameObject bananaHolder;
    public GameObject lemonHolder;
    public GameObject strawberryHolder;


    public void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        idx = 0;
        //spawnFruit();
        spawnBanana();
        spawnCherry();
        spawnLemon();
        spawnStrawberry();
        sounds = gameObject.AddComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            ChangeFruit(true);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            ChangeFruit(false);
        }
    }

    public void ChangeFruit(bool left)
    {
        if (left)
        {
            if (idx >= fruits.Length - 1)
            {
                idx = 0;
            }
            else
            {
                idx++;
            }
        }
        else
        {
            if (idx <= 0)
            {
                idx = fruits.Length - 1;
            }
            else
            {
                idx--;
            }
        }
        spawnFruit();
        playSound();
    }

    public void playSound()
    {
        sounds.clip = fruitsSound[idx];
        sounds.Play();
    }

    public void spawnFruit()
    {
        GameObject prev = GameObject.FindGameObjectWithTag("fruit");

        if (prev != null) Destroy(prev);

        GameObject mob = Instantiate(fruits[idx]);
        mob.transform.SetParent(placeHolder.transform, false);
        mob.transform.localScale = new Vector3(4000, 4000, 4000);

        spawnBanana();
        spawnCherry();
        spawnLemon();
        spawnStrawberry();
    }

    public void spawnCherry(){
        //GameObject prev = GameObject.FindGameObjectWithTag("fruit");

        //if (prev != null) Destroy(prev);

        GameObject cherryNow = Instantiate(cherry);
        cherryNow.transform.SetParent(cherryHolder.transform, false);
        cherryNow.transform.localScale = new Vector3(4000, 4000, 4000);
    }

    public void spawnBanana()
    {
        //GameObject prev = GameObject.FindGameObjectWithTag("fruit");

        //if (prev != null) Destroy(prev);

        GameObject bananaNow = Instantiate(banana);
        bananaNow.transform.SetParent(bananaHolder.transform, false);
        bananaNow.transform.localScale = new Vector3(4000, 4000, 4000);
    }

    public void spawnLemon()
    {
        //GameObject prev = GameObject.FindGameObjectWithTag("fruit");

        //if (prev != null) Destroy(prev);

        GameObject lemonNow = Instantiate(lemon);
        lemonNow.transform.SetParent(lemonHolder.transform, false);
        lemonNow.transform.localScale = new Vector3(4000, 4000, 4000);
    }

    public void spawnStrawberry()
    {
        //GameObject prev = GameObject.FindGameObjectWithTag("fruit");

        //if (prev != null) Destroy(prev);

        GameObject strawberryNow = Instantiate(strawberry);
        strawberryNow.transform.SetParent(strawberryHolder.transform, false);
        strawberryNow.transform.localScale = new Vector3(4000, 4000, 4000);
    }



}
