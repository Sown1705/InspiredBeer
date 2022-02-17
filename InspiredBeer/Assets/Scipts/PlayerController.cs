
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
        
    }
    public static float speed = 10f;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.Translate(Vector2.left * speed * Time.deltaTime);

        }
        else if(Input.GetKey(KeyCode.RightArrow) )
        {
            gameObject.transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        
    }

}
