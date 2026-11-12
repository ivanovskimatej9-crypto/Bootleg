using UnityEngine;

public class Collectieles : MonoBehaviour
{
   public void OnTriggerEnter2D(Collider2D other)
    {
     if (other.CompareTag("Player"))
        {
              Debug.Log("Destroy Player");
              Destroy(other.gameObject);
        }
    
    }
    

}
