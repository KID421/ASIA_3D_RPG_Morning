using UnityEngine;

public class NPC : MonoBehaviour
{
    private string npcName = "聖誕老狼";
    private string npcContent = "年輕人，可以幫我找十個寶箱嗎？";

    [Header("對話系統")]
    public DialogSystem ds;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "玩家")
        {
            ds.ShowDialog(npcName, npcContent);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "玩家")
        {
            ds.HideDialog();
        }
    }
}
