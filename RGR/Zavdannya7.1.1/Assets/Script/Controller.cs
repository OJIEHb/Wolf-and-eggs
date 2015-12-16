using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{

    public GameObject Volck;
    public GameObject Coube;
    public Sprite Left_Top, Left_Bottom, Right_Top, Right_Bottom;
    public Image Help;
    public Text Score, Die;
    public Button[] Button;
    public Button _Reload;
    public bool Active;
    public float Money, Life;
	
	void Update ()
    {
        KeyControl();
        ScoreCount();
	}
   
    void ScoreCount()
    {
        Score.GetComponent<Text>().text = "Score " + Money.ToString();
        Die.GetComponent<Text>().text = "Life " + Life.ToString();
        if (Life == 0)
        {
            Time.timeScale = 0;
            _Reload.gameObject.SetActive (true);
        }
    }

    void KeyControl()
    {
        if (Time.timeScale == 1)
        {
            if (Input.GetKey(KeyCode.Keypad1))
            {
                LeftBottom();
            }
            if (Input.GetKey(KeyCode.Keypad4))
            {
                LeftTop();
            }
            if (Input.GetKey(KeyCode.Keypad3))
            {
                RightBottom();
            }
            if (Input.GetKey(KeyCode.Keypad6))
            {
                RightTop();
            }
        }
        if (Input.GetKeyDown("escape"))
        {
            Active = true;
            Time.timeScale = 0;
        } 
        if (Input.GetKeyUp("escape"))
        {
            Active = false;
            Time.timeScale = 1;
        }
        if (Active)
        {
            Help.enabled = true;
        } else
        {
            Help.enabled = false;
        }
    }

    public void LeftBottom()
    {
        Volck.GetComponent<SpriteRenderer>().sprite = Left_Bottom;
        Volck.GetComponent<CircleCollider2D>().offset = new Vector2(-1.94f, -0.23f);
    }

    public void LeftTop()
    {
        Volck.GetComponent<SpriteRenderer>().sprite = Left_Top;
        Volck.GetComponent<CircleCollider2D>().offset = new Vector2(-1.25f, 1.9f);
    }

    public void RightBottom()
    {
        Volck.GetComponent<SpriteRenderer>().sprite = Right_Bottom;
        Volck.GetComponent<CircleCollider2D>().offset = new Vector2(1.94f, -0.23f);
    }

    public void RightTop()
    {
        Volck.GetComponent<SpriteRenderer>().sprite = Right_Top;
        Volck.GetComponent<CircleCollider2D>().offset = new Vector2(1.25f, 1.9f);
    }
    
    public void Reload()
    {
        SceneManager.LoadSceneAsync (0);
    }
}
