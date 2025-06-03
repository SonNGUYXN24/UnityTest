using UnityEngine;

public class PointBonus : MonoBehaviour
{
    public bool levelComplete = false; // Gắn true khi hoàn thành level
    public float timeRemaining = 0f; // Thời gian còn lại (giây)
    public int bonusPerSecond = 1000; // 1s = 1000 điểm
    private bool bonusCalculated = false; // Đảm bảo chỉ tính một lần

    void Update()
    {
        if (levelComplete && !bonusCalculated)
        {
            CalculateBonus();
            bonusCalculated = true; // Không tính lại nữa
        }
    }

    void CalculateBonus()
    {
        int bonusPoints = Mathf.RoundToInt(timeRemaining * bonusPerSecond);
        Debug.Log("Bonus points awarded: " + bonusPoints);

        // TODO: Truyền điểm này vào PlayerScore script sau
        // ví dụ: PlayerScore.Instance.AddScore(bonusPoints);
    }
}
