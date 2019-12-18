using UnityEngine;

public class Player : MonoBehaviour
{
    #region 欄位區域
    [Header("動畫參數名稱")]
    public string parRun = "跑步開關";
    public string parJump = "跳躍開關";
    public string parAtk = "攻擊觸發";
    public string parDamage = "受傷觸發";
    public string parDead = "死亡開關";
    [Header("道具")]
    public int countNeed = 10;
    public int countCurrent;
    [Header("數值")]
    public bool isDead;
    [Range(0, 500)]
    public float hp = 100;

    public Animator ani;
    #endregion

    #region 方法區域
    /// <summary>
    /// 跑步
    /// </summary>
    private void Run()
    {
        //print("水平 " + Input.GetAxis("Horizontal")); // Horizontal A 左 -1、D 右 1、沒按 0
        //print("垂直 " + Input.GetAxis("Vertical"));   // Vertical   S 下 -1、W 上 1、沒按 0

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        ani.SetBool("跑步開關", h != 0 || v != 0);  // 水平 不等於 0 或者 垂直 不等於 0 就跑步
    }

    /// <summary>
    /// 跳躍
    /// </summary>
    private void Jump()
    {
        ani.SetBool("跳躍開關", Input.GetKeyDown(KeyCode.Space));

        /**
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("跳躍動畫");
            ani.SetBool("跳躍開關", true);
        }
        else
        {
            ani.SetBool("跳躍開關", false);
        }
        */
    }

    /// <summary>
    /// 攻擊
    /// </summary>
    private void Attack()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            //print("攻擊動畫");
            ani.SetTrigger("攻擊觸發");
        }
    }

    /// <summary>
    /// 受傷
    /// </summary>
    /// <param name="damage">接收傷害值</param>
    private void Damage(float damage)
    {

    }

    /// <summary>
    /// 死亡
    /// </summary>
    private void Dead()
    {

    }

    /// <summary>
    /// 吃道具
    /// </summary>
    private void EatProp()
    {

    }

    /// <summary>
    /// 過關
    /// </summary>
    private void Pass()
    {

    }
    #endregion

    private void Update()
    {
        Jump();
        Attack();
        Run();
    }
}
