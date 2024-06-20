using UnityEngine;

public static class TransformExtensions
{
    public static void FlipX(this GameObject gameObject)
    {
        gameObject.transform.localScale = new Vector3(-gameObject.transform.localScale.x, gameObject.transform.localScale.y, gameObject.transform.localScale.z);
    }
    public static void FlipX(this Component component) => component.gameObject.FlipX();

    public static void FlipY(this GameObject gameObject)
    {
        gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x, -gameObject.transform.localScale.y, gameObject.transform.localScale.z);
    }
    public static void FlipY(this Component component) => component.gameObject.FlipY();
}