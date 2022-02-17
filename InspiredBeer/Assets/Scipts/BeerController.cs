using UnityEngine.UI;
using UnityEngine;


public class BeerController : MonoBehaviour
{

    // Start is called before the first frame update
    public GameObject bumm;
    public Text scoreText;
    public static int point = 0;
    void Start()
    {

        scoreText = GameObject.Find("Score").GetComponent<Text>();
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "duoi")
        {
            point--;
            scoreText.text = "Score : " + point;
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Player")
        {
            point++;
            scoreText.text = "Score : " + point;
            Destroy(gameObject);
            GameObject prefabs = Instantiate(bumm, gameObject.transform.position, Quaternion.identity);
            Destroy(prefabs, 1);
        }

        if (collision.gameObject.tag == "Obstacle")
        {
            point--;
            scoreText.text = "Score : " + point;
            Destroy(collision.gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
