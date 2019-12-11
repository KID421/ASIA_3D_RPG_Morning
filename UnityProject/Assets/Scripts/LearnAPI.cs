﻿using UnityEngine;

public class LearnAPI : MonoBehaviour
{
    // 非靜態
    // 先定義一個欄位
    // 公開 類別 名稱(代號)
    public Transform test1;
    public Transform test2;

    private void Start()
    {
        // 取得屬性：代號.屬性
        print(test1.position);
        // 設定屬性：代號.屬性 = 值

        test1.localScale = new Vector3(20, 20, 20);

        test2.localScale = Vector3.one * 5;
    }
}
