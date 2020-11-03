using UnityEngine;

public class GameManager : MonoBehaviour
{
    // 註解：說明
    // 定義欄位：儲存資料
    // 語法：
    // 修飾詞 類型 名稱；
    // 私人 private (預設)  - 不會顯示在屬性面板
    // 公開 public          - 會顯示在屬性面板
    // C# 支援中文
    // 欄位標題
    // 語法：[Header("文字訊息")]
    // ( ) [ ] { } ' ' " "
    [Header("兔子")]
    public Transform rabbit;
    [Header("蝙蝠")]
    public Transform bat;
    [Header("虛擬搖桿")]
    public FixedJoystick joystick;
    [Header("旋轉速度"), Range(0.1f, 20f)]
    public float turn = 1.5f;
    [Header("縮放"), Range(0f, 5f)]
    public float size = 0.3f;

    // 事件：在特定時間會執行的區塊 (名稱為藍色)
    // 開始事件：遊戲開始執行一次 - 初始設定
    private void Start()
    {
        print("開始事件");
    }

    // 更新事件：遊戲每個影格會執行一次
    // 一秒 60 格 (60FPS)
    // 一秒執行 約 60 次
    // 控制物件移動、旋轉、縮放或玩家輸入
    private void Update()
    {
        print("更新事件");
        print(joystick.Vertical);                                           // 虛擬搖桿 的 垂直資訊，float 浮點數 有小數點的數值

        bat.Rotate(0, joystick.Horizontal * turn, 0);                       // 蝙蝠.旋轉(0，虛擬搖桿的水平，0);
        rabbit.Rotate(0, joystick.Horizontal * turn, 0);
        
        // += 累加(遞增)
        bat.localScale += new Vector3(1, 1, 1) * joystick.Vertical * size;  // 蝙蝠.區域尺寸 = 新 三維向量(1，1，1) * 虛擬搖桿的垂直
    }
}
