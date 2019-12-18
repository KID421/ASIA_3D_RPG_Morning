using UnityEngine;
using UnityEngine.UI;   // 引用 介面 API

public class DialogSystem : MonoBehaviour
{
    [Header("介面")]
    public Text textName;
    public Text textContent;
    public CanvasGroup uiGroup;

    /// <summary>
    /// 顯示對話系統，透明度改為 1，並且更新對話名稱與內容。
    /// </summary>
    /// <param name="getName">取得對方名稱</param>
    /// <param name="getContent">取得對方對話內容</param>
    public void ShowDialog(string getName, string getContent)
    {
        uiGroup.alpha = 1;
        textName.text = getName;
        textContent.text = getContent;
    }

    public void HideDialog()
    {
        uiGroup.alpha = 0;
    }
}
