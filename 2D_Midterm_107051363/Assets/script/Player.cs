using UnityEngine;
using UnityEngine.UI; //引用介面API

public class Player : MonoBehaviour
{
    public GameObject final;
    
    public Text textCount;

    public int count;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name =="傳送門")
        {
            final.SetActive(true);
        }
        if (collision.tag == "星星")
        {
            Destroy(collision.gameObject);
            count++;
            textCount.text = "星星數量：" + count;
        }
    } 
}
