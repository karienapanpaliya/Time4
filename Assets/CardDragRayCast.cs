using UnityEngine;

public class CardDragRaycast : MonoBehaviour
{
    private bool isDragging;
    private Vector3 offset;
    private Camera cam;

    void Start()
    {
        cam = Camera.main;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mouseWorld = cam.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mouseWorld, Vector2.zero);

            if (hit.collider != null && hit.collider.gameObject == gameObject)
            {
                isDragging = true;
                offset = transform.position - (Vector3)mouseWorld;
                Debug.Log("Picked up " + gameObject.name);
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            isDragging = false;
        }

        if (isDragging)
        {
            Vector2 mouseWorld = cam.ScreenToWorldPoint(Input.mousePosition);
            transform.position = mouseWorld + (Vector2)offset;
        }
    }
}
