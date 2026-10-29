using UnityEngine;

public class PlayerInteractions : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coin"))
        {
            GameManager.instance.AddCoin();
            Destroy(other.gameObject);
        }
    }
}