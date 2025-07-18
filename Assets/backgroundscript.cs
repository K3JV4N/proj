using UnityEngine;

public class BackgroundScaler : MonoBehaviour
{
  void Start()
{
    SpriteRenderer sr = GetComponent<SpriteRenderer>();
    if (sr == null) return;

    float width = sr.sprite.bounds.size.x;
    float height = sr.sprite.bounds.size.y;

    float worldScreenHeight = Camera.main.orthographicSize * 2f;
    float worldScreenWidth = worldScreenHeight * Screen.width / Screen.height;

    //Debug.Log($"Sprite size: {width} x {height}");
   // Debug.Log($"World screen size: {worldScreenWidth} x {worldScreenHeight}");

    transform.localScale = new Vector3(
        worldScreenWidth / width,
        worldScreenHeight / height,
        1f
    );
}

    
}
