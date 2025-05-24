using UnityEngine;

public class SpeedControl3 : MonoBehaviour
{
    public enum SpeedMode
    {
        Easy,
        Normal,
        Hard,
        Extreme,
        Ultra
    }

    public SpeedMode currentMode = SpeedMode.Normal;

    public float moveSpeed = 0f;
    public float maxInputTime = 5f;

    private float inputTimer = 0f;
    private bool isMoving = false;

    void Update()
    {
        if (!isMoving)
        {
            inputTimer += Time.deltaTime;

            if (inputTimer < maxInputTime)
            {
                if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
                {
                    float increment = GetSpeedIncrement(currentMode);
                    moveSpeed += increment;
                    Debug.Log($"現在の速さ: {moveSpeed}（モード: {currentMode}）");
                }
            }
            else
            {
                isMoving = true;
                Debug.Log("移動開始！");
            }
        }
        else
        {
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        }
    }

    float GetSpeedIncrement(SpeedMode mode)
    {
        switch (mode)
        {
            case SpeedMode.Easy: return 0.5f;
            case SpeedMode.Normal: return 1f;
            case SpeedMode.Hard: return 2f;
            case SpeedMode.Extreme: return 3f;
            case SpeedMode.Ultra: return 5f;
            default: return 1f;
        }
    }
}

