using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using UnityEngine.SceneManagement;
public class RandomBoxSpawner : MonoBehaviour
{
    [Header("Object to move")]
    public GameObject targetObject;
    [Header("Spawn Areas (BoxCollider2D)")]
    public BoxCollider2D[] spawnAreas;
    [Header("Clickable Area")]
    public BoxCollider2D clickArea;
    private void Start()
    {
        StartCoroutine(MoveAfterDelay());
    }
    private void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            if (IsTouchingMouse(clickArea.gameObject))
            {
                Debug.Log("Clicked inside the box collider!");
                MoveObject();
                SceneManager.LoadScene(1);
            }
        }
    }
    IEnumerator MoveAfterDelay()
    {
        yield return new WaitForSeconds(2f);
        MoveObject();
    }
    void MoveObject()
    {
        if (targetObject == null)
        {
            Debug.LogError("No target object assigned!");
            return;
        }
        if (spawnAreas == null || spawnAreas.Length == 0)
        {
            Debug.LogError("No spawn areas assigned!");
            return;
        }
        BoxCollider2D area = spawnAreas[Random.Range(0, spawnAreas.Length)];
        Vector2 randomPos = GetRandomPointInBounds(area.bounds);
        targetObject.transform.position = randomPos;
    }
    Vector2 GetRandomPointInBounds(Bounds bounds)
    {
        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);
        return new Vector2(x, y);
    }
    bool IsTouchingMouse(GameObject g)
    {
        Vector2 mousePos = Mouse.current.position.ReadValue();
        Vector2 worldPoint =
            Camera.main.ScreenToWorldPoint(mousePos);
        return g.GetComponent<Collider2D>()
            .OverlapPoint(worldPoint);
    }
}