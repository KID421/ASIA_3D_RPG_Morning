using UnityEngine;
using UnityEngine.UI; // 引用 介面 API

public class EatProp : MonoBehaviour
{
    [Header("寶箱數量介面")]
    public Text textCount;
    [Header("提示畫面")]
    public GameObject objTip;

    public int propCount;       // 目前寶箱數量
    public int propTotal = 10;  // 寶箱總數

    public bool finish;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "寶箱")
        {
            Destroy(collision.gameObject);

            propCount++;                                            // 遞增
            textCount.text = "寶箱：" + propCount + " / 10";        // 更新介面

            // 如果 目前數量 等於 總數 顯示 勝利提示
            if (propCount == propTotal)
            {
                finish = true;
                objTip.SetActive(true);
            }
        }
    }
}
