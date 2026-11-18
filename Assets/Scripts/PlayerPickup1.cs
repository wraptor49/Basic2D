using UnityEngine;

public class PlayerPickup1 : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Coin")
        {
            Destroy(other.transform.gameObject);
        }
    }
}
