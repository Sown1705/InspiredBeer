
using UnityEngine;

public class PlayingController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab;
    public GameObject prefabLy;

    float TimeT;
    float duration = 1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    public static int totalDuration = 0;
    void Update()
    {
        TimeT += Time.deltaTime;
        var position = new Vector3(Random.Range(-9, 0), 5.8f, 0); ;
        if (TimeT>=duration)
        {
            TimeT = 0f;
            Instantiate(prefab, position, Quaternion.identity);
            totalDuration++;
        }
       
        if (totalDuration == 10)
        { 
            duration = 0.7f;
            PlayerController.speed = 15f;
        }
        else if (totalDuration == 20)
        {
            duration = 0.4f;
            PlayerController.speed = 20f;
        }
        else if (totalDuration == 30)
        {
            duration = 0.1f;
            PlayerController.speed = 30f;
           
        }


    }
    
}
