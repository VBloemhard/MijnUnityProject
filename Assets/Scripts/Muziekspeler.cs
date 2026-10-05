using UnityEngine;

public class Muziekspeler : MonoBehaviour
{
    string currentSong = "";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Playsong("505, Arctic Monkeys");
        Stopsong();
        SetVolume(5.5f);
    }




    void Playsong(string songName)
    {
         Debug.Log("Now playing " +  songName);
    }

    void Stopsong()
    {
        Debug.Log(currentSong + " is stopped");
    }

    void SetVolume(float volume)
    {
        if (volume >= 0 && volume <= 10)
        {
            
            
            Debug.Log("Volume is now " + volume);
           
       
        
        }
        else
        {
            Debug.Log("volume kan niet lager");
        }
    
    }


}


