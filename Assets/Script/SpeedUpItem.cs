using UnityEngine;

public class SpeedUpItem : MonoBehaviour
{
    public float SpeedBoost = 1.2f;
    public float duration = 5f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            PlayerController player = collision.GetComponent<PlayerController>();

            if (player != null)
            {
                player.moveSpeed = SpeedBoost;

                Destroy(gameObject);
                Debug.Log("속도 업! 현재 속도:" + player.moveSpeed);
            }
        }
    }
   
}
