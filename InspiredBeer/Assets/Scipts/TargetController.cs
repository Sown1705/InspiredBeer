
using UnityEngine;
using UnityEngine.UI;

public class TargetController : MonoBehaviour
{
    public Sprite[] womens;
     Image img;
    // Start is called before the first frame update
    void Start()
    {
        img = gameObject.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (BeerController.point == 5)
        {
            img.sprite = womens[0];
        }
        else if (BeerController.point == 10)
        {
            img.sprite = womens[1];
        }
        else if (BeerController.point == 15)
        {
            img.sprite = womens[2];
        }
        else if (BeerController.point == 20)
        {
            img.sprite = womens[3];

        }
        else if (BeerController.point == 25)
        {
            img.sprite = womens[4];

        }
        
    }
}
