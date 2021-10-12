using UnityEngine;
 
public class Square : MonoBehaviour
{
    public GameObject enemy;
    public float spawnTime = 3f;
    public Transform[] spawnPoints;
 
 
    void Start ()
    {
        //Mengeksekusi fungs Spawn setiap beberapa detik sesui dengan nilai spawnTime
        InvokeRepeating ("Spawn", spawnTime, spawnTime);
        //Spawn ();
    }
 
 
    void Spawn ()
    {
        Vector3 posisitionSquare = new Vector3(Random.Range(-10f, 10f), Random.Range(-3f, 3f), 0f);

        //Mendapatkan nilai random
        int spawnPointIndex = Random.Range (0, spawnPoints.Length);
 
        //Memduplikasi enemy
        Instantiate (enemy, posisitionSquare, spawnPoints[spawnPointIndex].rotation);
    }
}
