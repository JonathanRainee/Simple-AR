using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    public static Sounds instance;

    public AudioClip[] clip;
    List<AudioSource> sounds = new List<AudioSource>();

    // Start is called before the first frame update

    public void Awake()
    {
        instance = this;
    }

    void Start()
    {
        sounds.Clear();

        for(int i = 0; i < clip.Length; i++)
        {
            sounds.Add(gameObject.AddComponent<AudioSource>());
            sounds[i].clip = clip[i];
        }
    }

    public void playSound(int i)
    {
        sounds[i].Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
