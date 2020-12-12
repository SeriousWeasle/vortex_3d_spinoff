using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;
    public GameObject laser;
    public Material enemyMat;

    public Text scoreCounter;
    public Image healthbar;
    public Image laserbar;

    public GameObject gameUI;

    public GameObject gameOver;
    public Text final;

    public Image gameOverDot;

    public float score;

    public float health { private set; get; } = 400;
    public float laserCharge { private set; get; } = 400;

    public bool hasDied = false;

    public float gameoverscale = 0.1f;

    Enemy eh;
    void Start()
    {
        eh = enemy.GetComponent<Enemy>();
    }

    private void endGame()
    {
        enemy.SetActive(false);
        player.SetActive(false);
        gameUI.SetActive(false);
        gameOver.SetActive(true);
        final.text = Mathf.Round(score).ToString();
    }

    void Update()
    {
        Vector3 player_enemy_dist = enemy.transform.position - player.transform.position;
        if (player_enemy_dist.magnitude < eh.scale / 2 && !hasDied)
        {
            health -= (400 * Time.deltaTime); //subtract health
        }

        else if (health < 300 && !hasDied)
        {
            health += (10f * Time.deltaTime); //health regen
        }

        print(health);

        if (Input.GetButton("Fire1") && laserCharge > 0 && !hasDied) //firing
        {
            laser.SetActive(true);
            eh.isDamaging = true;
            laserCharge -= (25f * Time.deltaTime); //subtract laser energy
        }

        else
        {
            laser.SetActive(false);
            eh.isDamaging = false;
            if (laserCharge < 300 && !Input.GetButton("Fire1"))
            {
                laserCharge += (25f * Time.deltaTime); //add laser energy if not firing
            }
        }

        if (health <= 0)
        {
            hasDied = true;
            endGame();
        }

        if (!hasDied)
        {
            score += (100f * Time.deltaTime);
            scoreCounter.text = Mathf.Round(score).ToString();
        }

        laserbar.rectTransform.localScale = new Vector3(laserCharge / 400, 1, 1);
        laserbar.rectTransform.anchoredPosition = new Vector3((laserCharge / 2) - 200, laserbar.rectTransform.anchoredPosition.y, 0);
        if (!hasDied)
        {
            healthbar.rectTransform.localScale = new Vector3(health / 400, 1, 1);
            healthbar.rectTransform.anchoredPosition = new Vector3((health / 2) - 200, healthbar.rectTransform.anchoredPosition.y, 0);
        }
        else
        {
            healthbar.rectTransform.localScale = new Vector3(0, 1, 1);
        }

        if (hasDied && gameoverscale < 50)
        {
            gameoverscale += 5f * Time.deltaTime;
            gameOverDot.rectTransform.localScale = new Vector3(gameoverscale, gameoverscale, 0);
        }
    }
}
