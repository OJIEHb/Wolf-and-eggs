using UnityEngine;
using System.Collections;

public class EggsCreator1 : MonoBehaviour
{

    public Rigidbody2D Eggs;
    public float Tim, TimMax, TimMin;
	void Start ()
    {
        _Time();
    }

    void _Time()
    {
        Tim = Random.Range(9f, 10f);
        Time.timeScale = 1;
    }
	
	void Update ()
    {
        Eggs_Creator();
	}

    void Eggs_Creator()
    {
        Tim -= Time.deltaTime;
        if (Tim <= 0)
        {
            Tim = Random.Range(TimMin, TimMax);
            Rigidbody2D _Eggs = Instantiate(this.Eggs, transform.position, transform.rotation) as Rigidbody2D;
        }
    }
}
