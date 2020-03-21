using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour
{

    public Animator animator;//변수생성

    private float h;//Horizontal
    private float v;//Vertical

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>(); // 초기화될때 객체생성시 애니매이터 컴포넌트 가져옴
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) // getkeydown은 점프에서 해야함 점프를 getkey로하면 계속 점프함 누를때만 점프하게해야함
            //Down 지우고 시도. 취소
        {
            animator.Play("JUMP00", -1, 0);
        }
        h = Input.GetAxis("Horizontal"); //수평 수직의 정보를 담음
        v = Input.GetAxis("Vertical"); // 키보드를 누르면 정보가 담김

        animator.SetFloat("h", h); // 사용자로부터 키보드입력받으면
        animator.SetFloat("v", v); // 2d처럼 상하좌우로 움직이는거 만든것임 수평수직이 h v 임
    }
}
