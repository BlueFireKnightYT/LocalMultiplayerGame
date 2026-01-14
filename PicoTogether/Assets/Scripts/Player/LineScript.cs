using UnityEngine;

public class LineScript : MonoBehaviour
{
    public Transform player1;
    public Transform player2;

    [SerializeField] LineRenderer lr;

    private void Start()
    {
        GetComponent<LineRenderer>();
    }

    private void Update()
    {
        lr.SetPosition(0, player1.position);
        lr.SetPosition(1, player2.position);
    }
}
