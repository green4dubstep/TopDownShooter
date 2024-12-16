using UnityEngine;

public class CrosshairController : MonoBehaviour
{
    public Transform player; 
    public Camera cam; 
    public float cursorDistance = 2.0f; 

    private void Awake()
    {
         player = transform.parent;
    }

    void Update()
    {
        if(!GameManager.gameManager.isPaused)
        {
            Vector3 mousePosition = cam.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = 0;

            Vector3 direction = (mousePosition - player.position).normalized;

            transform.position = player.position + direction * cursorDistance;

            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0, 0, angle);
        }
        
    }
}
