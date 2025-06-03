using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerScore : MonoBehaviour
{
    public int score = 0;

    [Header("Tag Settings")]
    // Không cần LayerMask nữa vì dùng Tag
    [SerializeField] private PlayerScore playerScore;

    public TMP_Text scoreText;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Butterfly"))
        {   
            score += 200;
            Destroy(other.gameObject);
            Debug.Log("Ăn bướm! +200 điểm. Tổng điểm: " + score);

            UpdateScoreUI();
        }
        else if (other.CompareTag("Chauchau"))
        {
            score += 100;
            Destroy(other.gameObject);
            Debug.Log("Ăn châu chấu! +100 điểm. Tổng điểm: " + score);

            UpdateScoreUI();
        }
    }

    public void AddScore(int value)
    {
        score += value;
        Debug.Log("Thêm điểm từ script khác! + " + value + " điểm. Tổng điểm: " + score);

        UpdateScoreUI();
    }

    private void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = score.ToString();
        }
    }
}
