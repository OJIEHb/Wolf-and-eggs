using UnityEngine;

public class DestroyEggs : MonoBehaviour
{

    void OnTriggerEnter2D (Collider2D col)
    {
        Volck(col);
        Pol(col);
    }

   void Volck(Collider2D col)
    {
        if (col.gameObject.name == "volck")
        {
            GameObject.Find("Control").GetComponent<Controller>().Money = GameObject.Find("Control").GetComponent<Controller>().Money + 20;
            Destroy(gameObject);
        }
    }

    void Pol(Collider2D col)
    {
        if (col.gameObject.name == "pol")
        {
            GameObject.Find("Control").GetComponent<Controller>().Life = GameObject.Find("Control").GetComponent<Controller>().Life - 1;
            Destroy(gameObject);
        }
    }
}
