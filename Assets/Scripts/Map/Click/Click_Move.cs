using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click_Move : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Transform movePoint;

    public LayerMask Stopmovement;  //주변에 있는지 확인 하기 위해 벽 layer를 받아 오기 위함
    public bool click = false;  
    public GameObject[] button = new GameObject[4]; //이동 버튼들을 받아옴
    // Start is called before the first frame update
    void Start()    //시작 할때 모든 이동 버튼 비활성화
    {
        movePoint.parent = null;
        for(int i = 0; i < 4; i++)
        {
            button[i].SetActive(false); 
        }
    }

    // Update is called once per frame
    void Update()
    {
        button[0].transform.position = movePoint.position + new Vector3(1, 0, 0);
        button[1].transform.position = movePoint.position + new Vector3(-1, 0, 0);
        button[2].transform.position = movePoint.position + new Vector3(0, 1, 0);
        button[3].transform.position = movePoint.position + new Vector3(0, -1, 0);  //모든 버튼의 위치 조정
        if (click)
        {
            transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime);
            if (player_random.move_point > 0)
            {

                if (Vector3.Distance(transform.position, movePoint.position) <= .05f)
                {
                    if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(1, 0f, 0f), .2f, Stopmovement)) // 플레이어 우측에 벽이 없을 시에 이동 버튼 생성
                    {
                        button[0].SetActive(true);
                    }
                    if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(-1, 0f, 0f), .2f, Stopmovement)) // 플레이어 좌측에 벽이 없을 시에 이동 버튼 생성
                    {
                        button[1].SetActive(true);
                    }
                    if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(0f, 1, 0f), .2f, Stopmovement)) // 플레이어 위에 벽이 없을 시에 이동 버튼 생성
                    {
                        button[2].SetActive(true);
                    }
                    if (!Physics2D.OverlapCircle(movePoint.position + new Vector3(0f, -1, 0f), .2f, Stopmovement)) // 플레이어 아래에 벽이 없을 시에 이동 버튼 생성
                    {
                        button[3].SetActive(true);
                    }

                }
            }
        }
    }

    public void Buttonoff() // 하나의 버튼이 클릭 됬을 때 활성화 되어있는 버튼들을 끄기 위한 함수 
    {
        for (int i = 0; i < 4; i++)
        {
            button[i].SetActive(false);
        }
    }
    public void ButtonRight()
    {
        movePoint.transform.position += new Vector3(1, 0, 0);//클릭시에 movepoint의 위치 이동, movepoint이동시 플레이어 이동 스크립트에 따라서 플레이어 이동
        player_random.move_point--; // 이동수 차감
        Buttonoff();
    }
    public void ButtonLeft()
    {
        movePoint.transform.position += new Vector3(-1, 0, 0);  //클릭시에 movepoint의 위치 이동, movepoint이동시 플레이어 이동 스크립트에 따라서 플레이어 이동
        player_random.move_point--; // 이동수 차감
        Buttonoff();
    }
    public void ButtonUp()
    {
        movePoint.transform.position += new Vector3(0, 1, 0);//클릭시에 movepoint의 위치 이동, movepoint이동시 플레이어 이동 스크립트에 따라서 플레이어 이동
        player_random.move_point--; // 이동수 차감
        Buttonoff();
    }
    public void ButtonDown()
    {
        movePoint.transform.position += new Vector3(0, -1, 0);//클릭시에 movepoint의 위치 이동, movepoint이동시 플레이어 이동 스크립트에 따라서 플레이어 이동
        player_random.move_point--; // 이동수 차감
        Buttonoff();
    }
}
